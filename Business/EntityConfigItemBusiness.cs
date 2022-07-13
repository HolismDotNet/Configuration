namespace Configuration;

public class EntityConfigItemBusiness : Business<EntityConfigItemView, EntityConfigItem>
{
    protected override Read<EntityConfigItemView> Read => Repository.EntityConfigItemView;

    protected override Write<EntityConfigItem> Write => Repository.EntityConfigItem;

    public List<EntityConfigItemView> GetConfigs(string entityType)
    {
        var entityTypeGuid = new EntityTypeBusiness().GetGuid(entityType);
        var configItems = GetList(i => i.EntityTypeGuid == entityTypeGuid);
        return configItems;
    }
}