namespace Configuration;

public class EntityConfigItem : IEntity, IOrder
{
    public EntityConfigItem()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid EntityTypeGuid { get; set; }

    public long ConfigItemId { get; set; }

    public long Order { get; set; }

    public dynamic RelatedItems { get; set; }
}
