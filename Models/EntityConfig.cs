namespace Configuration;

public class EntityConfig : IEntity
{
    public EntityConfig()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid EntityGuid { get; set; }

    public long ConfigItemId { get; set; }

    public string CurrentValue { get; set; }

    public dynamic RelatedItems { get; set; }
}
