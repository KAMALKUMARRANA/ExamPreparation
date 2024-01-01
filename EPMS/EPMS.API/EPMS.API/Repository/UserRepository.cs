using EPMS.API.Data;
using EPMS.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EPMS.API.Repository
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
