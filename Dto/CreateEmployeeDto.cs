using System.ComponentModel.DataAnnotations;
using TrainingApp.Models;

namespace TrainingApp.Dto
{
    public class CreateEmployeeDto
    {
        public int EmployeeId { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; } = null!;
        [MaxLength(50)]
        public string LastName { get; set; } = null!;
        public EmployeeType Position { get; set; }

    }
}
