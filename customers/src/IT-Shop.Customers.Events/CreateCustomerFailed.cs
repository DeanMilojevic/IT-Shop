using System;
using Newtonsoft.Json;

namespace IT_Shop.Customers.Events
{
    public class CreateCustomerFailed
    {
        [JsonConstructor]
        public CreateCustomerFailed(Guid id, string reason)
        {
            Id = id;
            Reason = reason;
        }

        public Guid Id { get; }
        public string Reason { get; }
    }
}
