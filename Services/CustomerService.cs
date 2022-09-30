using System.Text.Json;
using TrainingApp.Models;

namespace TrainingApp.Services
{
    public class CustomerService
    {
        public CustomerService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.ContentRootPath, "Data", "CustomerData.json"); }
        }

        public IEnumerable<Customer> GetCustomers()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Customer[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                });
            }
        }


    }
}
