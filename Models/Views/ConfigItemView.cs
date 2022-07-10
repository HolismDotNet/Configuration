namespace Configuration;

public class ConfigItemView : IEntity, IKey
{
    public ConfigItemView()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Key { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public long ConfigTypeId { get; set; }

    public string TypeKey { get; set; }

    public dynamic RelatedItems { get; set; }
}
