using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SeuCeva.Data;

/* This is used if database provider does't define
 * ISeuCevaDbSchemaMigrator implementation.
 */
public class NullSeuCevaDbSchemaMigrator : ISeuCevaDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
