using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SeuCeva;

[Dependency(ReplaceServices = true)]
public class SeuCevaBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SeuCeva";
}
