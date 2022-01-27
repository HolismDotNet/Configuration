namespace Configuration;

public class ConfigItemBusiness : Business<ConfigItemView, ConfigItem>
{
    protected override Repository<ConfigItem> WriteRepository => RepositoryConfigItem;

    protected override ReadRepository<ConfigItemView> ReadRepository => RepositoryConfigItemView;
}
