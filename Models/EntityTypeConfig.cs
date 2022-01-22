namespace Configuration;

public class EntityTypeConfig : IEntity
{
    public EntityTypeConfig()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid EntityTypeGuid { get; set; }

    public long ConfigItemId { get; set; }

    public string CurrentValue { get; set; }

    public dynamic RelatedItems { get; set; }
}
