using ClassLibrary.Models;

namespace EFCoreTutorials.Models.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployee();
        Task<IEnumerable<Employee>> Search(string name,Gender? gender);
        Task<Employee> GetEmployeeById(int employeeId);
        Task<Employee> GetEmployeeByEmail(string email);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(int Ids,UpdatedEmployee updatedEmployee);
        Task<Employee> DeleteEmployee(int employeeId);

    }
}
