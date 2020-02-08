using System;
namespace IT_Shop.Customers.Core.Commands
{
    public class CreateCustomer
    {
        public CreateCustomer(
            Guid id,
            string billingZipCode, string billingStreet, string billingNumber,
            string shippingZipCode, string shippingStreet, string shippingNumber)
        {
            Id = id;
            BillingZipCode = billingZipCode;
            BillingStreet = billingStreet;
            BillingNumber = billingNumber;
            ShippingZipCode = shippingZipCode;
            ShippingStreet = shippingStreet;
            ShippingNumber = shippingNumber;
        }

        public Guid Id { get; }
        public string BillingZipCode { get; }
        public string BillingStreet { get; }
        public string BillingNumber { get; }
        public string ShippingZipCode { get; }
        public string ShippingStreet { get; }
        public string ShippingNumber { get; }
    }
}
