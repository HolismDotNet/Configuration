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

    public void SaveConfigs(string entityType, Guid entityGuid, Dictionary<long, object> newConfigs)
    {
        var existingConfigs = GetList(i => i.EntityGuid == entityGuid);
        foreach (var newConfig in newConfigs)
        {
            var value = newConfig.Value == null ? "" : newConfig.Value.ToString();
            var existingConfig = existingConfigs.FirstOrDefault(i => i.ConfigItemId == newConfig.Key);
            if (existingConfig == null)
            {
                Create(new EntityConfig
                {
                    ConfigItemId = newConfig.Key,
                    CurrentValue = value,
                    EntityGuid = entityGuid
                });
            }
            else 
            {
                existingConfig.CurrentValue = value;
                Update(existingConfig.CastTo<EntityConfig>());
            }
        }
    }
}