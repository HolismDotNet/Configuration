using Holism.Business;
using Holism.Configuration.DataAccess;
using Holism.Configuration.Models;
using Holism.EntityFramework;
using Holism.Framework;
using Holism.Framework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Holism.Configuration.Business
{
    public class ConfigurationItemBusiness : Business<ConfigurationItem, ConfigurationItem>
    {
        protected override Repository<ConfigurationItem> WriteRepository => RepositoryFactory.ConfigurationItem;

        protected override ViewRepository<ConfigurationItem> ReadRepository => RepositoryFactory.ConfigurationItem;

        protected override void ModifyItemBeforeReturning(ConfigurationItem item)
        {
            item.RelatedItems.Key = item.Namespace + "-" + item.Name;
        }

        public string Get(string @namespace, string name)
        {
            var configurationItem = GetOrNull(i => i.Namespace == @namespace && i.Name == name);
            if (configurationItem.IsNull())
            {
                throw new FrameworkException($"Configuration item {@namespace}-{name} is not present in database.");
            }
            return configurationItem.CurrentValue;
        }

        public static List<ConfigurationItem> GetPublicConfigurations()
        {
            var keys = new List<string> { "HasPasswordRecovery", "HasRegistration" };
            var configurations = RepositoryFactory.ConfigurationItem.All.Where(i => keys.Contains(i.Name)).ToList();
            return configurations;
        }
    }
}
