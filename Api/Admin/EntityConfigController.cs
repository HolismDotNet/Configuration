namespace Configuration;

public class EntityConfigController : Controller<EntityConfigView, EntityConfig>
{
    public override ReadBusiness<EntityConfigView> ReadBusiness => new EntityConfigBusiness();

    public override Business<EntityConfigView, EntityConfig> Business => new EntityConfigBusiness();

    [HttpGet]
    public List<EntityConfigView> GetConfigs(string entityType, Guid entityGuid)
    {
        var configs = new EntityConfigBusiness().GetConfigs(entityType, entityGuid);
        return configs;
    }

    [HttpPost]
    public List<EntityConfigView> Save(string entityType, Guid entityGuid)
    {
        var newConfigs = new Dictionary<long, object>();
        var storedConfigs = new EntityConfigBusiness().GetConfigs(entityType, entityGuid);

        foreach (var item in storedConfigs)
        {
            newConfigs.Add(item.ConfigItemId, HttpContext.ExtractProperty(item.ConfigItemId.ToString()));
        }
        new EntityConfigBusiness().SaveConfigs(entityType, entityGuid, newConfigs);
        storedConfigs = new EntityConfigBusiness().GetConfigs(entityType, entityGuid);
        return storedConfigs;
    }
}