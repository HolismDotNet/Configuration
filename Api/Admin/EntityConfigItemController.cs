namespace Configuration;

public class EntityConfigItemController : Controller<EntityConfigItemView, EntityConfigItem>
{
    public override ReadBusiness<EntityConfigItemView> ReadBusiness => new EntityConfigItemBusiness();

    public override Business<EntityConfigItemView, EntityConfigItem> Business => new EntityConfigItemBusiness();
}