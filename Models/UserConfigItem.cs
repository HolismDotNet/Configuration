namespace Holism.Configuration.Models
{
    public class UserConfigItem : Holism.Models.IEntity
    {
        public UserConfigItem()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public long ConfigItemId { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
