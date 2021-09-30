using System;

namespace Holism.Configuration.Models
{
    public class EntityTypeConfig : Holism.Models.IEntity
    {
        public EntityTypeConfig()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid EntityTypeGuid { get; set; }

        public string Fqn { get; set; }

        public long TypeId { get; set; }

        public string CurrentValue { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
