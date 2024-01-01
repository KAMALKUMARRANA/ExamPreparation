
using Bogus;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PEMS_UI.Models;


namespace PEMS_UI.Data
{
    public class DataContext : IdentityDbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Language>  language{ get; set; }
        public DataContext(DbContextOptions options) : base(options)
        {
        }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(GetEmployees());
        } 
        private List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            var faker = new Faker("en");
            for(int i = 1; i <= 50; i++)
            {
                var employee = new Employee
                {
                    Id = i,
                    ImgUrl=faker.Internet.Avatar(),
                    Name=faker.Name.FullName(),
                    Salary=GetRandomSalary(),
                    Type=GetRandomEmployeeType(),
                    Position=GetRandomPosition(),
                    Email=faker.Address.FullAddress()
            
                   
                   

                };
                employees.Add(employee);
            }
            return employees;
        }

        private Position GetRandomPosition()
        {
            var random = new Random();
            var position = Enum.GetValues(typeof(Position));
            return (Position)position.GetValue(random.Next(position.Length));
        }

        private EmployeeType GetRandomEmployeeType()
        {
            var random=new Random();
            var types=Enum.GetValues(typeof(EmployeeType));
            return (EmployeeType)types.GetValue(random.Next(types.Length));
        }

        private decimal GetRandomSalary()
        {
            var random = new Random();
            decimal salary = random.Next(30000, 100000);


            return salary;


        }
        
    }
}
