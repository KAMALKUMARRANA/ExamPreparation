using EPMS.Web.Data;
using EPMS.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace EPMS.Web.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataBaseContext dataBaseContext;

        public UserRepository(DataBaseContext dataBaseContext)

        {
            this.dataBaseContext = dataBaseContext;
        }

        public Task<User> AddEmployee(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> DeleteEmployee(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetUser()
        {
           return await dataBaseContext.Users.ToListAsync();
        }

        public Task<User> GetEmployeeById(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateEmployee(User user)
        {
            throw new NotImplementedException();
        }
    }
}
