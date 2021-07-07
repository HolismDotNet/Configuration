namespace Holism.Configuration.Models
{
    public class Option : Holism.Models.IEntity
    {
        public Option()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public long ItemId { get; set; }

        public string Value { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
