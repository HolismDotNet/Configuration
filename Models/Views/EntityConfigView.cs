namespace Configuration;

public class EntityConfigView : IEntity
{
    public EntityConfigView()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid EntityGuid { get; set; }

    public long ConfigItemId { get; set; }

    public string CurrentValue { get; set; }

    public string ConfigItemName { get; set; }

    public long ConfigTypeId { get; set; }

    public string TypeKey { get; set; }

    public dynamic RelatedItems { get; set; }
}
