using ClassLibrary.Models;
using EFCoreTutorials.Data;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTutorials.Models.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DataBaseContext dataBaseContext;

        public DepartmentRepository(DataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }
        public async Task<Department> AddDepartment(Department department)
        {
            var result=await dataBaseContext.Departments.AddAsync(department);
            await dataBaseContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Department> GetDepartmentById(int departmantId)
        {
            var result=await dataBaseContext.Departments.FirstOrDefaultAsync(d=>d.DepartmentId==departmantId);
            return result;
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await dataBaseContext.Departments.ToListAsync();
        }
    }
}
