using SeuCeva.Localization;
using Volo.Abp.AspNetCore.Components;

namespace SeuCeva.Blazor;

public abstract class SeuCevaComponentBase : AbpComponentBase
{
    protected SeuCevaComponentBase()
    {
        LocalizationResource = typeof(SeuCevaResource);
    }
}
