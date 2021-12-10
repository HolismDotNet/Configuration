namespace Holism.Configuration.Models;

public class SystemConfigView : IEntity
{
    public SystemConfigView()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long ConfigItemId { get; set; }

    public string CurrentValue { get; set; }

    public string ConfigItemName { get; set; }

    public long TypeId { get; set; }

    public string TypeKey { get; set; }

    public dynamic RelatedItems { get; set; }
}
