using Holism.Business;
using Holism.DataAccess;
using Holism.Framework;
using Holism.Configuration.DataAccess;
using Holism.Configuration.Models;
using Microsoft.VisualBasic;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Holism.Configuration.Business
{
    public class OptionBusiness : Business<Option, Option>
    {
        
        protected override Repository<Option> WriteRepository => Repository.Option;

        protected override ReadRepository<Option> ReadRepository => Repository.Option;
 
        // protected override void ModifyItemBeforeReturning(ConfigurationItem item)
        // {
        //     item.RelatedItems.Key = item.Namespace + "-" + item.Name;
        // }

        // public string Get(string @namespace, string name)
        // {
        //     var configurationItem = GetOrNull(i => i.Namespace == @namespace && i.Name == name);
        //     if (configurationItem.IsNull())
        //     {
        //         throw new FrameworkException($"Configuration item {@namespace}-{name} is not present in database.");
        //     }
        //     return configurationItem.CurrentValue;
        // }

        // protected override void BeforeCreation(ConfigurationItem model, object extraParameters = null)
        // {
        //     throw new FrameworkException("Creation of configuration items is not permitted");
        // }

        // protected override void BeforeDeletion(ConfigurationItem model)
        // {
        //     throw new FrameworkException("Deletion of configuration items is not permitted");
        // }

        // public static List<ConfigurationItem> GetPublicConfigurations()
        // {
        //     var keys = new List<string> { "HasPasswordRecovery", "HasRegistration" };
        //     var configurations = RepositoryFactory.ConfigurationItem.All.Where(i => keys.Contains(i.Name)).ToList();
        //     return configurations;
        // }
 

    }
}
