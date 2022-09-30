using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace TrainingApp.Models
{
    public class User
    {
        [MaxLength(50)]
        public string FirstName { get; set; } = null!;
        [MaxLength(50)]
        public string LastName { get; set; } = null!;

        public string DisplayName { get; } = null!;
     
    }
}
