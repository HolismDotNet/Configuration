namespace Holism.Configuration.Models;

public class SystemConfig : IEntity
{
    public SystemConfig()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long ConfigItemId { get; set; }

    public string CurrentValue { get; set; }

    public dynamic RelatedItems { get; set; }
}
