namespace Configuration;

public class ConfigItemBusiness : Business<ConfigItemView, ConfigItem>
{
    protected override Write<ConfigItem> Write => Repository.ConfigItem;

    protected override Read<ConfigItemView> Read => Repository.ConfigItemView;
}
