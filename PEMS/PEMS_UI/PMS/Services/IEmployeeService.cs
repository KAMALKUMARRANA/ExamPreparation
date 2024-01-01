using PEMS_UI.Models.DTOs;
using PEMS_UI.Models.Responses;
using PEMS_UI.Models;

namespace PEMS_UI.Services
{
    public interface IEmployeeService
    {
        Task<GetEmployeesResponse> GetEmployees();
        Task<BaseResponse> AddEmployee(AddEmployeeForm form);
        Task<GetEmployeeResponse> GetEmployee(int id);
        Task<BaseResponse> DeleteEmployee(Employee employee);
        Task<BaseResponse> EditEmployee(Employee employee);
        Task<List<Language>> GetLanguage();
    }
}
