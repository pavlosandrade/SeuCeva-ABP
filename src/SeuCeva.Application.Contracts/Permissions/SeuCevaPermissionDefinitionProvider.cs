using SeuCeva.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SeuCeva.Permissions;

public class SeuCevaPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SeuCevaPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SeuCevaPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SeuCevaResource>(name);
    }
}
