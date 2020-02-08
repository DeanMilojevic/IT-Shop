using System;
using GreenPipes;
using IT_Shop.Customers.Messaging.Consumers;
using MassTransit;
using MassTransit.AspNetCoreIntegration;
using MassTransit.ExtensionsDependencyInjectionIntegration;
using Microsoft.Extensions.DependencyInjection;

namespace IT_Shop.Customers.Messaging.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMessaging(this IServiceCollection services)
        {
            IBusControl CreateBus(IServiceProvider serviceProvider)
            {
                return Bus.Factory.CreateUsingRabbitMq(configurator =>
                {
                    configurator.Host("rabbitmq://localhost"); // todo config

                    configurator.ReceiveEndpoint("user-signed-up", endpoint =>
                    {
                        endpoint.PrefetchCount = 16;
                        endpoint.UseMessageRetry(retry => retry.Interval(2, 100));

                        endpoint.ConfigureConsumer<UserSignedUpConsumer>(serviceProvider);
                    });
                });
            }

            static void ConfigureMassTransit(IServiceCollectionConfigurator configurator)
            {
                configurator.AddConsumer<UserSignedUpConsumer>();
            }

            services.AddMassTransit(CreateBus, ConfigureMassTransit);

            return services;
        }
    }
}
