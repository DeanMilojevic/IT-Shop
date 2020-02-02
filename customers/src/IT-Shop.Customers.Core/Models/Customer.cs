using System;

namespace IT_Shop.Customers.Core.Models
{
    public class Customer
    {
        public Customer(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; }
        public string Name { get; }
    }
}
