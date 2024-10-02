namespace EMS_BO
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentID { get; set; }

        public Department Department { get; set; }  // Navigation property for Department
    }
}
