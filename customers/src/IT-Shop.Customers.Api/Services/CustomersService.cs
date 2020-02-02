using System.Threading.Tasks;
using Grpc.Core;
using IT_Shop.Customers.Api.Generated;
using Microsoft.Extensions.Logging;

namespace ITShop.Customers.Api.Services
{
    public class CustomersService : CustomersService.CustomersServiceBase
    {
        private readonly ILogger<CustomersService> _logger;

        public CustomersService(ILogger<CustomersService> logger)
        {
            _logger = logger;
        }

        public override Task<CustomerModel> Get(CustomerQuery request, ServerCallContext context)
        {
            _logger.LogInformation("Get the customer @{request}", request);
            return Task.FromResult(new CustomerModel());
        }

        public override Task<CustomersModel> GetAll(BrowseCustomersQuery request, ServerCallContext context)
        {
            _logger.LogInformation("Get the customers @{request}", request);
            return Task.FromResult(new CustomersModel());
        }
    }
}
