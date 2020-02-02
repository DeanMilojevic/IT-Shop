using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IT_Shop.Customers.Core.Models;
using IT_Shop.Customers.Core.Queries;
using Mediator;

namespace IT_Shop.Customers.Core.MongoDB.QueryHandlers
{
    public class BrowseCustomersHandler : IQueryHandler<BrowseCustomers, IEnumerable<Customer>>
    {
        public BrowseCustomersHandler()
        {
        }

        public Task<IEnumerable<Customer>> Handle(BrowseCustomers query)
        {
            throw new NotImplementedException();
        }
    }
}
