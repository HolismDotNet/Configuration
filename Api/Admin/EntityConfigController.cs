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
}