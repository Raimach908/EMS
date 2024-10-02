using EMS_BO;
namespace EMS_DAL
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
        Department GetDepartmentById(int departmentId);
        void AddDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(int departmentId);
        IEnumerable<DepartmentStats> GetDepartmentStatistics();
    }
}
