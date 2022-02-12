namespace Configuration;

public class SystemConfigBusiness : Business<SystemConfigView, SystemConfig>
{
    protected override Write<SystemConfig> Write => Repository.SystemConfig;

    protected override Read<SystemConfigView> Read => Repository.SystemConfigView;

    public SystemConfigView SetValue(long id, object value)
    {
        var systemConfig = Write.Get(id);
        systemConfig.CurrentValue = value.ToString();
        Update(systemConfig);
        return Get(id);
    }
}
