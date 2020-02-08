namespace IT_Shop.Customers.Core.MongoDB.Entities
{
    public class Address
    {
        public Address(string zipCode, string street, string number)
        {
            ZipCode = zipCode;
            Street = street;
            Number = number;
        }

        public string ZipCode { get; }
        public string Street { get; }
        public string Number { get; }
    }
}
