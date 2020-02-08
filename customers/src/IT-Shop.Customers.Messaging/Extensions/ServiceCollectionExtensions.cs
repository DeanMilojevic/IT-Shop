using System;
using GreenPipes;
using IT_Shop.Customers.Messaging.Consumers;
using IT_Shop.Customers.Messaging.Options;
using MassTransit;
using MassTransit.AspNetCoreIntegration;
using MassTransit.ExtensionsDependencyInjectionIntegration;
using Microsoft.Extensions.DependencyInjection;

namespace IT_Shop.Customers.Messaging.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMessaging(this IServiceCollection services, MessagingOptions messagingOptions)
        {
            services.AddMassTransit(provider => CreateBus(provider, messagingOptions), ConfigureMassTransit);

            return services;
        }

        private static IBusControl CreateBus(IServiceProvider serviceProvider, MessagingOptions messagingOptions)
        {
            return Bus.Factory.CreateUsingRabbitMq(configurator =>
            {
                configurator.Host(messagingOptions.Host);

                configurator.ReceiveEndpoint("user-signed-up", endpoint =>
                {
                    endpoint.PrefetchCount = 1;
                    endpoint.UseMessageRetry(retry => retry.Interval(2, 100));

                    endpoint.ConfigureConsumer<UserSignedUpConsumer>(serviceProvider);
                });
            });
        }

        private static void ConfigureMassTransit(IServiceCollectionConfigurator configurator)
        {
            configurator.AddConsumer<UserSignedUpConsumer>();
        }
    }
}
