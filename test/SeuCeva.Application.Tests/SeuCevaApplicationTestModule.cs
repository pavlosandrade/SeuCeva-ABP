using Volo.Abp.Modularity;

namespace SeuCeva;

[DependsOn(
    typeof(SeuCevaApplicationModule),
    typeof(SeuCevaDomainTestModule)
    )]
public class SeuCevaApplicationTestModule : AbpModule
{

}
