using System;

namespace IT_Shop.Customers.Core.MongoDB.Entities
{
    public class Customer
    {
        public Customer(Guid id, Address billingAddress, Address shippingAddress)
        {
            Id = id;
            BillingAddress = billingAddress;
            ShippingAddress = shippingAddress;
        }

        public Guid Id { get; }
        public Address BillingAddress { get; }
        public Address ShippingAddress { get; }
    }
}
