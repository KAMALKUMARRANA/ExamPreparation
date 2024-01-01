using ClassLibrary.Models;

namespace EFCoreTutorials.Models.Repository
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartmentById(int departmantId);
        Task<Department> AddDepartment(Department department);
    }
}
