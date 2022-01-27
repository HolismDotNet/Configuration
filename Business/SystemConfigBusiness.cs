namespace Configuration;

public class SystemConfigBusiness : Business<SystemConfigView, SystemConfig>
{
    protected override Repository<SystemConfig> WriteRepository => RepositorySystemConfig;

    protected override ReadRepository<SystemConfigView> ReadRepository => RepositorySystemConfigView;

    public SystemConfigView SetValue(long id, object value)
    {
        var systemConfig = WriteRepository.Get(id);
        systemConfig.CurrentValue = value.ToString();
        Update(systemConfig);
        return Get(id);
    }
}
