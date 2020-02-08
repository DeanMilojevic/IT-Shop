using System.ComponentModel.DataAnnotations;

namespace IT_Shop.Customers.Messaging.Options
{
    public class MessagingOptions
    {
        public MessagingOptions()
        {
            [Required]
            public string Host { get; set; }
    }
    }
}
