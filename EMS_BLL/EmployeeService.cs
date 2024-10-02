using EMS_BO;
using EMS_DAL;

namespace EMS_BLL
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public EmployeeService(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            var employees = _employeeRepository.GetAllEmployees();

            foreach (var employee in employees)
            {
                employee.Department = _departmentRepository.GetDepartmentById(employee.DepartmentID);
            }

            return employees;
        }
        public void CreateEmployee(Employee employee)
        {
            // Validate if the department exists
            var department = _departmentRepository.GetDepartmentById(employee.DepartmentID);
            if (department == null)
            {
                throw new ArgumentException("Department does not exist.", nameof(employee.DepartmentID));
            }

            // Ensure that the salary is greater than zero
            if (employee.Salary <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(employee.Salary), "Salary must be greater than zero.");
            }

            // Calculate the total salary in the department
            var totalSalariesInDepartment = GetTotalSalaryByDepartment(employee.DepartmentID);

            // Check if adding the new employee's salary would exceed the department's budget
            if (totalSalariesInDepartment + employee.Salary > department.Budget)
            {
                throw new ArgumentOutOfRangeException(nameof(employee.Salary), "Total salary with the new employee exceeds the department's budget.");
            }

            // Add the employee
            _employeeRepository.AddEmployee(employee);
        }
        public void UpdateEmployee(Employee employee)
        {
            // Validate that the employee exists
            var existingEmployee = _employeeRepository.GetEmployeeById(employee.EmployeeID);
            if (existingEmployee == null)
            {
                throw new ArgumentException("Employee does not exist.", nameof(employee.EmployeeID));
            }

            // Check if the new department exists
            var newDepartment = _departmentRepository.GetDepartmentById(employee.DepartmentID);
            if (newDepartment == null)
            {
                throw new ArgumentException("New department does not exist.", nameof(employee.DepartmentID));
            }

            // Ensure that the updated salary is within valid limits
            if (employee.Salary <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(employee.Salary), "Salary must be greater than zero.");
            }

            // If the department is changing, check the budget
            if (existingEmployee.DepartmentID != employee.DepartmentID)
            {
                // Check if the new department has enough budget for the new salary
                if (employee.Salary > newDepartment.Budget)
                {
                    throw new ArgumentOutOfRangeException(nameof(employee.Salary), "New salary must be within the new department's budget.");
                }
            }
            else
            {
                // Ensure that the updated salary is within the current department's budget
                var currentDepartment = _departmentRepository.GetDepartmentById(existingEmployee.DepartmentID);
                if (employee.Salary >= currentDepartment.Budget)
                {
                    throw new ArgumentOutOfRangeException(nameof(employee.Salary), "Updated salary must be within the current department's budget.");
                }
            }

            // Update the employee
            _employeeRepository.UpdateEmployee(employee);
        }
        public void DeleteEmployee(int employeeId)
        {
            // Validate that the employee exists
            var employee = _employeeRepository.GetEmployeeById(employeeId);
            if (employee == null)
                throw new Exception("Employee does not exist.");

            // Proceed to delete the employee
            _employeeRepository.DeleteEmployee(employeeId);
        }
        // d) Department-wise Employee Analysis
        public decimal GetTotalSalaryByDepartment(int departmentId)
        {
            var employees = _employeeRepository.GetAllEmployees();
            decimal totalSalary = 0;

            foreach (var employee in employees)
            {
                if (employee.DepartmentID == departmentId)
                    totalSalary += employee.Salary;
            }

            return totalSalary;
        }

        public bool CanHireInDepartment(int departmentId, decimal salary)
        {
            var department = _departmentRepository.GetDepartmentById(departmentId);
            var totalSalaries = GetTotalSalaryByDepartment(departmentId);

            return totalSalaries + salary <= department.Budget;
        }
        public IEnumerable<Employee> SearchEmployees(string searchTerm)
        {
            var employees = _employeeRepository.GetAllEmployees();

            bool isDepartmentIdSearch = int.TryParse(searchTerm, out int departmentId);

            // Basic search by first name, last name, position, or department ID
            return employees.Where(e =>
                e.FirstName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                e.LastName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                e.Position.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (isDepartmentIdSearch && e.DepartmentID == departmentId));
        }
    }
}
