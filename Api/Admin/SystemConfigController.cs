namespace Configuration;

public class SystemConfigController : Controller<SystemConfigView, SystemConfig>
{
    public override ReadBusiness<SystemConfigView> ReadBusiness => new SystemConfigBusiness();
    
    public override Business<SystemConfigView, SystemConfig> Business => new SystemConfigBusiness();

    [HttpPost]
    public SystemConfigView SetValue(long id)
    {
        var value = Request.Query["value"];
        if (value.Count == 0)
        {
            throw new ClientException("Value is not provided");
        }
        var systemConfig = new SystemConfigBusiness().SetValue(id, value.First());
        return systemConfig;
    }
}
