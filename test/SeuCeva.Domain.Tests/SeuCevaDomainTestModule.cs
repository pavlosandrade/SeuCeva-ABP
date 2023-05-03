using SeuCeva.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SeuCeva;

[DependsOn(
    typeof(SeuCevaEntityFrameworkCoreTestModule)
    )]
public class SeuCevaDomainTestModule : AbpModule
{

}
