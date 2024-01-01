using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace EPMS.Data;

public class EPMSEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EPMSEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the EPMSDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<EPMSDbContext>()
            .Database
            .MigrateAsync();
    }
}
