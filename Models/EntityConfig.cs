using System;

namespace Holism.Configuration.Models
{
    public class EntityConfig : Holism.Models.IEntity
    {
        public EntityConfig()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid EntityGuid { get; set; }

        public long ConfigItemId { get; set; }

        public string CurrentValue { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
