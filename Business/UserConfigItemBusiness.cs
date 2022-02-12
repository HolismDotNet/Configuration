namespace Configuration;

public class UserConfigItemBusiness : Business<UserConfigItem, UserConfigItem>
{
    protected override Write<UserConfigItem> Write => Repository.UserConfigItem;

    protected override Read<UserConfigItem> Read => Repository.UserConfigItem;
}
