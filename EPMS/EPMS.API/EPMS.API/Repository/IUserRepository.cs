using EPMS.API.Models;
using System.Reflection;

namespace EPMS.API.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUser();
      
        Task<User> GetEmployeeById(int userId);
       
        Task<User> AddEmployee(User user);
        Task<User> UpdateEmployee(User user);
        Task<User> DeleteEmployee(int userId);
    }
}
