using System.Threading.Tasks;
using IT_Shop.Customers.Events;
using MassTransit;

namespace IT_Shop.Customers.Messaging.Consumers
{
    public class UserSignedUpConsumer : IConsumer<SignedUp>
    {
        public Task Consume(ConsumeContext<SignedUp> context)
        {
            throw new System.NotImplementedException();
        }
    }
}
