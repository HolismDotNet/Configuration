namespace Configuration;

public class SystemConfigController : Controller<SystemConfigView, SystemConfig>
{
    public override ReadBusiness<SystemConfigView> ReadBusiness => new SystemConfigBusiness();
    
    public override Business<SystemConfigView, SystemConfig> Business => new SystemConfigBusiness();

    [HttpPost]
    public IActionResult SetValue(long id, object value)
    {
        new SystemConfigBusiness().SetValue(id, value);
        return OkJson();
    }
}
