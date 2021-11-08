using System;

namespace Holism.Configuration.Models
{
    public class EntityConfigItem : Holism.Models.IEntity
    {
        public EntityConfigItem()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid EntityTypeGuid { get; set; }

        public long ConfigItemId { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
