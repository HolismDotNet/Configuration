using System;

namespace Holism.Configuration.Models
{
    public class UserConfig : Holism.Models.IEntity
    {
        public UserConfig()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid UserGuid { get; set; }

        public long ConfigItemId { get; set; }

        public string CurrentValue { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
