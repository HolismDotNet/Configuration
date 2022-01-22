namespace Configuration;

public class EntityConfigItemView : IEntity
{
    public EntityConfigItemView()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid EntityTypeGuid { get; set; }

    public long ConfigItemId { get; set; }

    public string ConfigItemName { get; set; }

    public long ConfigTypeId { get; set; }

    public string TypeKey { get; set; }

    public dynamic RelatedItems { get; set; }
}
