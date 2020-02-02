using System.Collections.Generic;
using IT_Shop.Customers.Core.Models;
using Mediator;

namespace IT_Shop.Customers.Core.Queries
{
    public class BrowseCustomers : IQuery<IEnumerable<Customer>>
    {
        public BrowseCustomers()
        {
        }
    }
}
