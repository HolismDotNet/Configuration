namespace Holism.Configuration.Models
{
    public class ConfigItem : Holism.Models.IEntity
    {
        public ConfigItem()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public long TypeId { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
