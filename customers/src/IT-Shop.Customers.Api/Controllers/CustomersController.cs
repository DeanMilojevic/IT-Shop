using System;
using System.Threading;
using System.Threading.Tasks;
using IT_Shop.Customers.Api.Models;
using IT_Shop.Customers.Core.Queries;
using Mediator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IT_Shop.Customers.Api.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;
        private readonly IDispatcher _dispatcher;

        public CustomersController(ILogger<CustomersController> logger, IDispatcher dispatcher)
        {
            _logger = logger;
            _dispatcher = dispatcher;
        }

        [HttpGet("/{id}")]
        public async Task<IActionResult> GetAsync(string id, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Get the customer @{id}", id);

            var result = await _dispatcher.Send(new GetCustomer(Guid.Parse(id)));

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(BrowseCustomersRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Browse customers: {@request}", request);

            var result = await _dispatcher.Send(new BrowseCustomers());

            return Ok();
        }
    }
}
