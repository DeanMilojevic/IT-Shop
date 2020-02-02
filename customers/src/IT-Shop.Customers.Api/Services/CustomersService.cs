using System;
using System.Threading.Tasks;
using Grpc.Core;
using IT_Shop.Customers.Api.Generated;
using IT_Shop.Customers.Core.Queries;
using Mediator;
using Microsoft.Extensions.Logging;

namespace ITShop.Customers.Api.Services
{
    public class CustomersService : IT_Shop.Customers.Api.Generated.CustomersService.CustomersServiceBase
    {
        private readonly ILogger<CustomersService> _logger;
        private readonly IDispatcher _dispatcher;

        public CustomersService(ILogger<CustomersService> logger, IDispatcher dispatcher)
        {
            _logger = logger;
            _dispatcher = dispatcher;
        }

        public override async Task<CustomerModel> Get(CustomerQuery request, ServerCallContext context)
        {
            _logger.LogInformation("Get the customer @{request}", request);

            var result = await _dispatcher.Send(new GetCustomer(Guid.Parse(request.Id)));

            return new CustomerModel
            {
                Id = result.Id.ToString(),
                Name = result.Name
            };
        }

        public override async Task<CustomersModel> GetAll(BrowseCustomersQuery request, ServerCallContext context)
        {
            _logger.LogInformation("Get the customers @{request}", request);

            var result = await _dispatcher.Send(new BrowseCustomers());

            var responseModel = new CustomersModel();

            foreach (var customer in result)
            {
                responseModel.Customers.Add(new CustomerModel { Id = customer.Id.ToString(), Name = customer.Name });
            }

            return responseModel;
        }
    }
}
