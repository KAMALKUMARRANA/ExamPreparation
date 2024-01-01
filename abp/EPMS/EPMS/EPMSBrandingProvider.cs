using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace EPMS;

[Dependency(ReplaceServices = true)]
public class EPMSBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "EPMS";
}
