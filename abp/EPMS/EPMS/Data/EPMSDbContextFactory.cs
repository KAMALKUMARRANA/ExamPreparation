using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EPMS.Data;

public class EPMSDbContextFactory : IDesignTimeDbContextFactory<EPMSDbContext>
{
    public EPMSDbContext CreateDbContext(string[] args)
    {

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<EPMSDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new EPMSDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
