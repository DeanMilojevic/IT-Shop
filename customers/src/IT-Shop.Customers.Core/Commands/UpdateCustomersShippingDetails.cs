using System;
namespace IT_Shop.Customers.Core.Commands
{
    public class UpdateCustomersShippingDetails
    {
        public UpdateCustomersShippingDetails(
            Guid customerId,
            string zipCode, string street, string number)
        {
            CustomerId = customerId;
            ZipCode = zipCode;
            Street = street;
            Number = number;
        }

        public Guid CustomerId { get; }
        public string ZipCode { get; }
        public string Street { get; }
        public string Number { get; }
    }
}
