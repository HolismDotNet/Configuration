namespace Configuration;

public class EntityConfigController : Controller<EntityConfigView, EntityConfig>
{
    public override ReadBusiness<EntityConfigView> ReadBusiness => new EntityConfigBusiness();

    public override Business<EntityConfigView, EntityConfig> Business => new EntityConfigBusiness();
}