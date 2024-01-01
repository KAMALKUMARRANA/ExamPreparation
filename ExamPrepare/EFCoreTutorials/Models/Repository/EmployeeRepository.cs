using ClassLibrary.Models;
using EFCoreTutorials.Data;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTutorials.Models.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataBaseContext dataBaseContext;

        public EmployeeRepository(DataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await dataBaseContext.Employees.AddAsync(employee);
           await dataBaseContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employee> DeleteEmployee(int employeeId)
        {
         var result=await dataBaseContext.Employees.FirstOrDefaultAsync(e=>e.EmployeeId==employeeId);
            if (result != null)
            {
                dataBaseContext.Employees.Remove(result);
                await dataBaseContext.SaveChangesAsync();
            }
            return result;
        }

        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            return await dataBaseContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeByEmail(string email)
        {
           var result= await dataBaseContext.Employees.FirstOrDefaultAsync(e=>e.Email==email);
            return result;

        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return await dataBaseContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
        }

        public async Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        {
            IQueryable<Employee> query = dataBaseContext.Employees;
            if (!string.IsNullOrEmpty(name))
            {
                query=query.Where(e=>e.FirstName.Contains(name) || e.LastName.Contains(name));
            }
            if (gender != null)
            {
                query=query.Where(e=>e.Gender==gender);
            }
            return await query.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(int Id,UpdatedEmployee updatedEmployee)
        {
            var result = await dataBaseContext.Employees.FindAsync(Id);
            if(result != null)
            {
                result.FirstName =updatedEmployee.FirstName;
                result.LastName = updatedEmployee.LastName;
                result.Email = updatedEmployee.Email;
               
                result.DateOfBrith= updatedEmployee.DateOfBrith;
                result.PhotoPath = updatedEmployee.PhotoPath;
                result.Gender = updatedEmployee.Gender;
                await dataBaseContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

       
    }
}
