namespace TrainingApp.Models
{
    public class Customer : User
    {
        public int CustomerId { get; set; }
        public string Location { get; set; } = null!;

        public Customer(int customerId, string location, string firstName, string lastName)
        {
            CustomerId = customerId;
            Location = location;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
