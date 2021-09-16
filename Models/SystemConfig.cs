namespace Holism.Configuration.Models
{
    public class SystemConfig : Holism.Models.IEntity
    {
        public SystemConfig()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public string Fqn { get; set; }

        public long TypeId { get; set; }

        public string CurrentValue { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
