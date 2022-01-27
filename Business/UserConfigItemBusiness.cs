namespace Configuration;

public class UserConfigItemBusiness : Business<UserConfigItem, UserConfigItem>
{
    protected override Repository<UserConfigItem> WriteRepository => RepositoryUserConfigItem;

    protected override ReadRepository<UserConfigItem> ReadRepository => RepositoryUserConfigItem;
}
