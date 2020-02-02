using System;
using System.Threading.Tasks;
using IT_Shop.Customers.Core.Models;
using IT_Shop.Customers.Core.Queries;
using Mediator;

namespace IT_Shop.Customers.Core.MongoDB.QueryHandlers
{
    public class GetCustomerHandler : IQueryHandler<GetCustomer, Customer>
    {
        public GetCustomerHandler()
        {
        }

        public Task<Customer> Handle(GetCustomer query)
        {
            throw new NotImplementedException();
        }
    }
}
