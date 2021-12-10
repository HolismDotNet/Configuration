namespace Holism.Configuration.Models;

public class UserConfigItem : IEntity
{
    public UserConfigItem()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long ConfigItemId { get; set; }

    public dynamic RelatedItems { get; set; }
}
