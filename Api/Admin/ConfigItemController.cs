namespace Holism.Configuration.AdminApi;

public class ConfigItemController : Controller<ConfigItemView, ConfigItem>
{
    public override ReadBusiness<ConfigItemView> ReadBusiness => new ConfigItemBusiness();
    
    public override Business<ConfigItemView, ConfigItem> Business => new ConfigItemBusiness();
}