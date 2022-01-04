namespace Holism.Configuration.AdminApi;

public class ConfigTypeController : EnumController<ConfigType>
{
    public override EnumBusiness<ConfigType> EnumBusiness => new ConfigTypeBusiness();
}
