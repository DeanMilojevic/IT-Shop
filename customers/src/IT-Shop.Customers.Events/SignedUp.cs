using System;

namespace IT_Shop.Customers.Events
{
    public class SignedUp
    {
        public SignedUp(Guid userId, string email)
        {
            UserId = userId;
            Email = email;
        }

        public Guid UserId { get; }
        public string Email { get; }
    }
}
