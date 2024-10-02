using Dapper;
using EMS_BO;
using Microsoft.Data.SqlClient;

namespace EMS_DAL
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly string _connectionString;

        public DepartmentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Department>("SELECT * FROM Department");
            }
        }

        public Department GetDepartmentById(int departmentId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<Department>("SELECT * FROM Department WHERE DepartmentID = @Id", new { Id = departmentId });
            }
        }

        public void AddDepartment(Department department)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "INSERT INTO Department (DepartmentName, Budget) VALUES (@DepartmentName, @Budget)";
                connection.Execute(sql, department);
            }
        }

        public void UpdateDepartment(Department department)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "UPDATE Department SET DepartmentName = @DepartmentName, Budget = @Budget WHERE DepartmentID = @DepartmentID";
                connection.Execute(sql, department);
            }
        }

        public void DeleteDepartment(int departmentId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "DELETE FROM Department WHERE DepartmentID = @DepartmentID";
                connection.Execute(sql, new { DepartmentID = departmentId });
            }
        }
        public IEnumerable<DepartmentStats> GetDepartmentStatistics()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
            SELECT 
                d.DepartmentID, 
                d.Budget, 
                d.DepartmentName, 
                COUNT(e.EmployeeID) AS EmployeeCount, 
                SUM(e.Salary) AS TotalSalary
            FROM 
                Department d
            LEFT JOIN 
                Employee e ON d.DepartmentID = e.DepartmentID
            GROUP BY 
                d.DepartmentID, d.Budget, d.DepartmentName";

                return connection.Query<DepartmentStats>(sql);
            }
        }
    }
}
