using Microsoft.AspNetCore.Mvc;
using TrainingApp.Models;
using TrainingApp.Services;

namespace TrainingApp.Controllers
{
    [ApiController]
    [Route("customer")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        public CustomerService CustomerService;
        public IEnumerable<Customer> Customers { get; private set; }

        public CustomerController(ILogger<CustomerController> logger, CustomerService customerService, IEnumerable<Customer> customers)
        {
            _logger = logger;
            CustomerService = customerService;
            Customers = customers;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return Customers = CustomerService.GetCustomers();
        }
    }
}
