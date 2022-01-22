namespace Configuration;

public class UserConfigItemBusiness : Business<UserConfigItem, UserConfigItem>
{
    protected override Repository<UserConfigItem> WriteRepository =>
        Repository.UserConfigItem;

    protected override ReadRepository<UserConfigItem> ReadRepository =>
        Repository.UserConfigItem;
}
