using System;
using IT_Shop.Customers.Core.Models;
using Mediator;

namespace IT_Shop.Customers.Core.Queries
{
    public class GetCustomer : IQuery<Customer>
    {
        public GetCustomer(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
