namespace Configuration;

public class Option : IEntity
{
    public Option()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long ConfigItemId { get; set; }

    public string Value { get; set; }

    public dynamic RelatedItems { get; set; }
}
