using System;
using System.Collections.Generic;
using System.Text;
using SeuCeva.Localization;
using Volo.Abp.Application.Services;

namespace SeuCeva;

/* Inherit your application services from this class.
 */
public abstract class SeuCevaAppService : ApplicationService
{
    protected SeuCevaAppService()
    {
        LocalizationResource = typeof(SeuCevaResource);
    }
}
