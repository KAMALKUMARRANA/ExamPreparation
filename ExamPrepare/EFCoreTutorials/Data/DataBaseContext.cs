using ClassLibrary.Models;
using EFCoreTutorials.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTutorials.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
