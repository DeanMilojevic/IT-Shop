using System;

namespace IT_Shop.Customers.Events
{
    public class SignedUp
    {
        public SignedUp(Guid userId)
        {
            UserId = userId;
        }

        public Guid UserId { get; }
    }
}
