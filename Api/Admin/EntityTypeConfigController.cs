namespace Configuration;

public class EntityTypeConfigController : Controller<EntityTypeConfigView, EntityTypeConfig>
{
    public override ReadBusiness<EntityTypeConfigView> ReadBusiness => new EntityTypeConfigBusiness();

    public override Business<EntityTypeConfigView, EntityTypeConfig> Business => new EntityTypeConfigBusiness();   
}