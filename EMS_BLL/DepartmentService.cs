using EMS_BO;
using EMS_DAL;
using System.Collections.Generic;
using System.Linq;

namespace EMS_BLL
{
    public class DepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IEmployeeRepository _employeeRepository;

        public DepartmentService(IDepartmentRepository departmentRepository, IEmployeeRepository employeeRepository)
        {
            _departmentRepository = departmentRepository;
            _employeeRepository = employeeRepository;
        }
        public IEnumerable<DepartmentStats> SearchDepartmentById(int departmentId)
        {
            // Retrieve all department statistics
            var departments = _departmentRepository.GetDepartmentStatistics();

            // Check if the list is not null and contains departments with matching ID
            if (departments != null && departments.Any())
            {
                // Filter the department stats with the matching departmentId
                return departments.Where(department => department.DepartmentID == departmentId);
            }

            // Return an empty collection if no match found
            return Enumerable.Empty<DepartmentStats>();
        }
        public IEnumerable<DepartmentStats> GetDepartmentStatistics()
        {
            return _departmentRepository.GetDepartmentStatistics();
        }

        // Logic to calculate total salary spent in a department
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

        // Logic to ensure department does not exceed budget when hiring
        public bool CanHireInDepartment(int departmentId, decimal salary)
        {
            var department = _departmentRepository.GetDepartmentById(departmentId);
            var totalSalaries = GetTotalSalaryByDepartment(departmentId);

            return totalSalaries + salary <= department.Budget;
        }

        // Create a new department
        public void CreateDepartment(Department department)
        {
            _departmentRepository.AddDepartment(department);
        }

        // Update an existing department
        public void UpdateDepartment(Department department)
        {
            _departmentRepository.UpdateDepartment(department);
        }
        public void DeleteDepartment(int departmentId)
        {
            var department = _departmentRepository.GetDepartmentById(departmentId);
            if (department != null)
            {
                _departmentRepository.DeleteDepartment(departmentId); // Pass the ID here
            }
        }

        // Retrieve all departments
        public IEnumerable<Department> GetDepartments()
        {
            return _departmentRepository.GetAllDepartments();
        }
    }
}
