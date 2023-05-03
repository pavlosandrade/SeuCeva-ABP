using Volo.Abp.Settings;

namespace SeuCeva.Settings;

public class SeuCevaSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SeuCevaSettings.MySetting1));
    }
}
