using SeuCeva.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace SeuCeva.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SeuCevaEntityFrameworkCoreModule),
    typeof(SeuCevaApplicationContractsModule)
    )]
public class SeuCevaDbMigratorModule : AbpModule
{

}
