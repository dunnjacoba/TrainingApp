using System.Text.Json;
using TrainingApp.Models;

namespace TrainingApp.Services
{
    public class EmployeeService
    {
        public EmployeeService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.ContentRootPath, "Data", "EmployeeData.json"); }
        }

        public IEnumerable<Employee> GetEmployees()
        {
            using(var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Employee[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                    });
            }
        }

        public void UpdateEmployee(int employeeId)
        {
            var employees = GetEmployees();

            var query = employees.Where(x => x.EmployeeId == employeeId);

            if(query.Count() > 0)
            {
                var employee = query.ToString();
            }
        }

    }
}
