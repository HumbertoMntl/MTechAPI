namespace MTech.Models
{
    public enum EmployeeStatus
    {
        NotSet,
        Active,
        Inactive,
    }
    // Model class representing an Employee entity in the system.
    public class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string RFC { get; set; }

        public DateTime BornDate { get; set; }

        public EmployeeStatus Status { get; set; }

    }
}
