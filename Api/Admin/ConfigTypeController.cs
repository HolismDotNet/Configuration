namespace Configuration;

public class ConfigTypeController : EnumController<ConfigType>
{
    public override EnumBusiness<ConfigType> EnumBusiness => new ConfigTypeBusiness();
}
