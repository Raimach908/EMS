using Dapper;
using EMS_BO;
using Microsoft.Data.SqlClient;

namespace EMS_DAL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly string _connectionString;

        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Employee>("SELECT * FROM Employee");
            }
        }

        public Employee GetEmployeeById(int employeeId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<Employee>("SELECT * FROM Employee WHERE EmployeeID = @Id", new { Id = employeeId });
            }
        }

        public void AddEmployee(Employee employee)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "INSERT INTO Employee (FirstName, LastName, Position, Salary, DepartmentID) VALUES (@FirstName, @LastName, @Position, @Salary, @DepartmentID)";
                connection.Execute(sql, employee);
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, Position = @Position, Salary = @Salary, DepartmentID = @DepartmentID WHERE EmployeeID = @EmployeeID";
                connection.Execute(sql, employee);
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";
                connection.Execute(sql, new { EmployeeID = employeeId });
            }
        }

        public IEnumerable<Employee> GetEmployeesWithDepartmentDetails()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"SELECT e.*, d.DepartmentName 
                            FROM Employee e
                            INNER JOIN Department d ON e.DepartmentID = d.DepartmentID";
                return connection.Query<Employee, Department, Employee>(
                    sql,
                    (employee, department) =>
                    {
                        employee.Department = department;
                        return employee;
                    },
                    splitOn: "DepartmentID"
                );
            }
        }
    }
}
