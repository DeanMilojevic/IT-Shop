using System.Collections.Generic;
using IT_Shop.Customers.Core.Models;
using IT_Shop.Customers.Core.MongoDB.QueryHandlers;
using IT_Shop.Customers.Core.Queries;
using Mediator.AspNetCore.DependencyInjection.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace IT_Shop.Customers.Core.MongoDB.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMongo(this IServiceCollection services)
        {
            services.AddQueryHandler<GetCustomer, Customer, GetCustomerHandler>();
            services.AddQueryHandler<BrowseCustomers, IEnumerable<Customer>, BrowsseCustomersHandler>();

            return services;
        }
    }
}
