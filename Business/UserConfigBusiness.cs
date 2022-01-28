namespace Configuration;

public class UserConfigBusiness : Business<UserConfigView, UserConfig>
{
    protected override Repository<UserConfig> WriteRepository => Repository.UserConfig;

    protected override ReadRepository<UserConfigView> ReadRepository => Repository.UserConfigView;

    public override ListResult<UserConfigView> GetList(ListParameters listParameters)
    {
        var userGuid = Guid.Parse(listParameters.GetFilter("UserGuid").Value.ToString());
        SyncUserConfigsWithTemplateItems(userGuid);
        return base.GetList(listParameters);
    }

    public List<UserConfigView> GetUserConfigs(Guid userGuid)
    {
        var userConfigs = GetList(i => i.UserGuid == userGuid);
        return userConfigs;
    }

    public void SyncUserConfigsWithTemplateItems(Guid userGuid)
    {
        var userConfigItems = new UserConfigItemBusiness().GetAll();
        var configItemIds = userConfigItems.Select(i => i.ConfigItemId).ToList();
        var userConfigs = GetUserConfigs(userGuid);
        var userConfigItemIds = userConfigs.Select(i => i.ConfigItemId).ToList();
        var newConfigItemIds = configItemIds.Where(i => !userConfigItemIds.Contains(i)).ToList();
        var userConfigItemIdsToBeDeleted = userConfigItemIds.Where(i => !configItemIds.Contains(i)).ToList();

        var newUserConfigs = newConfigItemIds.Select(i => new UserConfig {
            ConfigItemId = i,
            UserGuid = userGuid
        }).ToList();
        WriteRepository.BulkInsert(newUserConfigs);

        var userConfigsToBeDeleted = userConfigs
        .Where(i => userConfigItemIdsToBeDeleted.Contains(i.ConfigItemId))
        .Select(i => i.CastTo<UserConfig>())
        .ToList();
        WriteRepository.BulkDelete(userConfigsToBeDeleted);
    }

    public UserConfigView SetValue(long id, object value, Guid userGuid)
    {
        var userConfig = WriteRepository.Get(id);
        if (userConfig.UserGuid != userGuid) 
        {
            throw new ClientException("Configuration item does not belong to the user");
        }
        userConfig.CurrentValue = value.ToString();
        Update(userConfig);
        return Get(id);
    }
}
