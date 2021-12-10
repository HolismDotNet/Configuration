namespace Holism.Configuration.Models;

public class ConfigItem : IEntity
{
    public ConfigItem()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Name { get; set; }

    public long TypeId { get; set; }

    public dynamic RelatedItems { get; set; }
}
