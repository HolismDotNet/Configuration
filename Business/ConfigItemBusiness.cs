namespace Configuration;

public class ConfigItemBusiness : Business<ConfigItemView, ConfigItem>
{
    protected override Repository<ConfigItem> WriteRepository => Repository.ConfigItem;

    protected override ReadRepository<ConfigItemView> ReadRepository => Repository.ConfigItemView;
}
