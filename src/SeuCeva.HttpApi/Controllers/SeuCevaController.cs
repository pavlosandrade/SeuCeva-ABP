using SeuCeva.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SeuCeva.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SeuCevaController : AbpControllerBase
{
    protected SeuCevaController()
    {
        LocalizationResource = typeof(SeuCevaResource);
    }
}
