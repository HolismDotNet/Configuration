using System;

namespace Holism.Configuration.Models
{
    public class EntityConfigItemView : Holism.Models.IEntity
    {
        public EntityConfigItemView()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid EntityTypeGuid { get; set; }

        public long ConfigItemId { get; set; }

        public string ConfigItemName { get; set; }

        public long TypeId { get; set; }

        public string TypeKey { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}