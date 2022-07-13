namespace Configuration;

public class EntityConfigBusiness : Business<EntityConfigView, EntityConfig>
{
    protected override Read<EntityConfigView> Read => Repository.EntityConfigView;

    protected override Write<EntityConfig> Write => Repository.EntityConfig;

    public List<EntityConfigView> GetConfigs(string entityType, Guid entityGuid)
    {
        var currentConfigs = GetList(i => i.EntityGuid == entityGuid);
        var entityConfigItems = new EntityConfigItemBusiness().GetConfigs(entityType);
        foreach (var item in entityConfigItems)
        {
            if (!currentConfigs.Any(i => i.ConfigItemId == item.ConfigItemId))
            {
                var temp = item.CastTo<EntityConfigView>();
                temp.EntityGuid = entityGuid;
                temp.Id = 0;
                temp.RelatedItems = new ExpandoObject();
                currentConfigs.Add(temp);
            }
        }
        currentConfigs = currentConfigs.OrderBy(i => i.ConfigItemId).ToList();
        return currentConfigs;
    }
}