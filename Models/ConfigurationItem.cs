namespace Holism.Configuration.Models
{
    public class ConfigurationItem : Holism.Models.IEntity
    {
        public ConfigurationItem()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public string Namespace { get; set; }

        public string Name { get; set; }

        public string PersianName { get; set; }

        public long TypeId { get; set; }

        public string CurrentValue { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
