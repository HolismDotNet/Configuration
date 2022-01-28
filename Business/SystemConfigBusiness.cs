namespace Configuration;

public class SystemConfigBusiness : Business<SystemConfigView, SystemConfig>
{
    protected override Repository<SystemConfig> WriteRepository => Repository.SystemConfig;

    protected override ReadRepository<SystemConfigView> ReadRepository => Repository.SystemConfigView;

    public SystemConfigView SetValue(long id, object value)
    {
        var systemConfig = WriteRepository.Get(id);
        systemConfig.CurrentValue = value.ToString();
        Update(systemConfig);
        return Get(id);
    }
}
