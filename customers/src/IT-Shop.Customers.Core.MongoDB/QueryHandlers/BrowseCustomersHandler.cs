using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IT_Shop.Customers.Core.Models;
using IT_Shop.Customers.Core.Queries;
using Mediator;
using MongoDB.Driver;
using CustomerEntity = IT_Shop.Customers.Core.MongoDB.Entities.Customer;

namespace IT_Shop.Customers.Core.MongoDB.QueryHandlers
{
    public class BrowseCustomersHandler : IQueryHandler<BrowseCustomers, IEnumerable<Customer>>
    {
        private readonly IMongoCollection<CustomerEntity> _customers;

        public BrowseCustomersHandler(IMongoDatabase database, string collection)
        {
            _customers = database.GetCollection<CustomerEntity> (collection);
        }

        public Task<IEnumerable<Customer>> Handle(BrowseCustomers query)
        {
            throw new NotImplementedException();
        }
    }
}
