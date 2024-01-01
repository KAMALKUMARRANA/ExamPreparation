using ClassLibrary.Models;

namespace EPMS.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await httpClient.GetFromJsonAsync<Employee>($"api/Employees/{id}");
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return (await httpClient.GetFromJsonAsync<Employee[]>("api/Employees"));
        }
    }
}
