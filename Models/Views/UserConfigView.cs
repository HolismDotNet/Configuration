using System;

namespace Holism.Configuration.Models
{
    public class UserConfigView : Holism.Models.IEntity
    {
        public UserConfigView()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid UserGuid { get; set; }

        public long ConfigItemId { get; set; }

        public string CurrentValue { get; set; }

        public string ConfigItemName { get; set; }

        public long TypeId { get; set; }

        public string TypeKey { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
