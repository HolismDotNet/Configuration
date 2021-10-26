namespace Holism.Configuration.Models
{
    public class ConfigItemView : Holism.Models.IEntity
    {
        public ConfigItemView()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public long TypeId { get; set; }

        public string TypeKey { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
