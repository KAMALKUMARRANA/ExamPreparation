using EPMS.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EPMS.API.Data
{
    public class DataBaseContext : DbContext

    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<AssignProject> AssignProjects { get; set; }

        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }



        public virtual DbSet<Project> Projects { get; set; }

        public virtual DbSet<User> Users { get; set; }
    }
}
