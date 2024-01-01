using EPMS.Localization;
using Volo.Abp.AspNetCore.Components;

namespace EPMS;

public abstract class EPMSComponentBase : AbpComponentBase
{
    protected EPMSComponentBase()
    {
        LocalizationResource = typeof(EPMSResource);
    }
}
