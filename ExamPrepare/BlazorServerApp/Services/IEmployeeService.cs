using ClassLibrary.Models;

namespace BlazorServerApp.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployeeById(int id);
        Task<HttpResponseMessage> UpdateEmployee(int id, Employee updatedEmployee);
    }
}
