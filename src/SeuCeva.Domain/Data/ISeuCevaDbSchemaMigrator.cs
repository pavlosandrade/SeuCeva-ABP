using System.Threading.Tasks;

namespace SeuCeva.Data;

public interface ISeuCevaDbSchemaMigrator
{
    Task MigrateAsync();
}
