namespace Configuration;

public class ConfigTypeBusiness : EnumBusiness<ConfigType>
{
    public override string ConnectionString => Repository.ConfigItem.ConnectionString;
}
