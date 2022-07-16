namespace Configuration;

public class EntityConfigBusiness : Business<EntityConfigView, EntityConfig>
{
    protected override Read<EntityConfigView> Read => Repository.EntityConfigView;

    protected override Write<EntityConfig> Write => Repository.EntityConfig;

    public List<EntityConfigView> GetConfigs(string entityType, Guid entityGuid)
    {
        var currentConfigs = GetList(i => i.EntityGuid == entityGuid);
        var entityConfigItems = new EntityConfigItemBusiness().GetConfigs(entityType);
        var orderIds = entityConfigItems.OrderBy(i => i.Order).Select(i => i.ConfigItemId).ToList();
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
        currentConfigs = currentConfigs.OrderBy(i => orderIds.IndexOf(i.ConfigItemId)).ToList();
        SetTypedValues(currentConfigs);
        return currentConfigs;
    }

    public object GetConfigsObject(string entityType, Guid entityGuid)
    {
        var configs = GetConfigs(entityType, entityGuid);
        dynamic @object = new ExpandoObject();
        foreach (var config in configs)
        {
            ExpandoObjectExtensions.AddProperty(@object, config.ConfigItemKey, config.RelatedItems.TypedValue);
        }
        return @object;
    }

    private void SetTypedValues(List<EntityConfigView> configs)
    {
        foreach (var config in configs)
        {
            switch (config.ConfigTypeId.CastTo<ConfigType>())
            {
                case ConfigType.Boolean:
                    config.RelatedItems.TypedValue = config.CurrentValue == null ? false : config.CurrentValue.ToBoolean();
                    break;
                case ConfigType.NaturalNumber:
                case ConfigType.Integer:
                case ConfigType.Percent:
                    config.RelatedItems.TypedValue = config.CurrentValue == null ? new Nullable<int>() : config.CurrentValue.ToInt();
                    break;
                case ConfigType.RealNumber:
                    config.RelatedItems.TypedValue = config.CurrentValue == null ? new Nullable<decimal>() : config.CurrentValue.ToDecimal();
                    break;
                case ConfigType.NullableBoolean:
                    config.RelatedItems.TypedValue = config.CurrentValue == null ? new Nullable<bool>() : config.CurrentValue.ToBoolean();
                    break;
                case ConfigType.SingleChoice:
                    config.RelatedItems.TypedValue = config.CurrentValue == null ? new Nullable<long>() : config.CurrentValue.ToLong();
                    break;
                case ConfigType.MultipleChoice:
                    config.RelatedItems.TypedValue = config.CurrentValue == null ? new List<long>() : config.CurrentValue.SplitCsv<long>();
                    break;
                default:
                    config.RelatedItems.TypedValue = config.CurrentValue;
                    break;
            }
        }
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