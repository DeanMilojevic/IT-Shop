using System;
using System.Threading.Tasks;
using IT_Shop.Customers.Core.Models;
using IT_Shop.Customers.Core.Queries;
using Mediator;
using MongoDB.Driver;
using CustomerEntity = IT_Shop.Customers.Core.MongoDB.Entities.Customer;

namespace IT_Shop.Customers.Core.MongoDB.QueryHandlers
{
    public class GetCustomerHandler : IQueryHandler<GetCustomer, Customer>
    {
        private readonly IMongoCollection<CustomerEntity> _customers;

        public GetCustomerHandler(IMongoDatabase database, string collection)
        {
            _customers = database.GetCollection<CustomerEntity>(collection);
        }

        public Task<Customer> Handle(GetCustomer query)
        {
            throw new NotImplementedException();
        }
    }
}
