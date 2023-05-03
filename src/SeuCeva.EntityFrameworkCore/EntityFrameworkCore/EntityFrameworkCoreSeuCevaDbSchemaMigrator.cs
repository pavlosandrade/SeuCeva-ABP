using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SeuCeva.Data;
using Volo.Abp.DependencyInjection;

namespace SeuCeva.EntityFrameworkCore;

public class EntityFrameworkCoreSeuCevaDbSchemaMigrator
    : ISeuCevaDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSeuCevaDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SeuCevaDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SeuCevaDbContext>()
            .Database
            .MigrateAsync();
    }
}
