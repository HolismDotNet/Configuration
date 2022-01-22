namespace Configuration;

public class ConfigItem : IEntity
{
    public ConfigItem()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Name { get; set; }

    public long ConfigTypeId { get; set; }

    public dynamic RelatedItems { get; set; }
}
