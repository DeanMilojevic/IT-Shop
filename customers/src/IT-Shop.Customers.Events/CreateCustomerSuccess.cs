using System;
using Newtonsoft.Json;

namespace IT_Shop.Customers.Events
{
    public class CreateCustomerSuccess
    {
        [JsonConstructor]
        public CreateCustomerSuccess(Guid id, string firstName, string lastName, string email, string address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
        }

        public Guid Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string Address { get; }
    }
}
