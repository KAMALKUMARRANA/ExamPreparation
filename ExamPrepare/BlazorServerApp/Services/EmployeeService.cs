using ClassLibrary.Models;

namespace BlazorServerApp.Services
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
            return await httpClient.GetFromJsonAsync<Employee>($"api/employees/{id}");
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await httpClient.GetFromJsonAsync<Employee[]>("api/employees");
        }
        public async Task<HttpResponseMessage> UpdateEmployee(int id,Employee updatedEmployee)
        {
            return (await httpClient.PutAsJsonAsync<Employee>("api/employees/{id}", updatedEmployee));


        }
    }
}
