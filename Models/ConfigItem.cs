namespace Configuration;

public class ConfigItem : IEntity, IKey
{
    public ConfigItem()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long ConfigTypeId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Key { get; set; }

    public dynamic RelatedItems { get; set; }
}
