namespace Holism.Configuration.Models;

public class UserConfig : IEntity
{
    public UserConfig()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid UserGuid { get; set; }

    public long ConfigItemId { get; set; }

    public string CurrentValue { get; set; }

    public dynamic RelatedItems { get; set; }
}
