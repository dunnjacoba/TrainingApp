namespace TrainingApp.Models
{
    public class Employee : User
    {
        public int EmployeeId { get; set; }
        public EmployeeType Position { get; set; }
        
        public Employee(string firstName, string lastName, EmployeeType position, int employeeId)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            EmployeeId = employeeId;
        }
    }
}
