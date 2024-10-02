using EMS_BO;
namespace EMS_DAL
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int employeeId);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
        IEnumerable<Employee> GetEmployeesWithDepartmentDetails();
    }
}
