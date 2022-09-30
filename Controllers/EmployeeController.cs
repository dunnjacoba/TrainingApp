using Microsoft.AspNetCore.Mvc;
using TrainingApp.Models;
using TrainingApp.Services;

namespace TrainingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
       private readonly ILogger<EmployeeController> _logger;
        public EmployeeService EmployeeService;
        public IEnumerable<Employee> Employees { get; private set; }

        public EmployeeController(ILogger<EmployeeController> logger, EmployeeService employeeService, IEnumerable<Employee> employees)
        {
            _logger = logger;
            EmployeeService = employeeService;
            Employees = employees; 
            
        }
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return EmployeeService.GetEmployees();
        }
        [HttpPut("{id:int}")]
        public void Update(int id)
        {            
                EmployeeService.UpdateEmployee(id);                       
        }
    }
}
