using Holism.Business;
using Holism.DataAccess;
using Holism.Infra;
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
    public class ConfigurationItemBusiness : Business<ConfigurationItem, ConfigurationItem>
    {
        protected override Repository<ConfigurationItem> WriteRepository => Repository.ConfigurationItem;

        protected override ReadRepository<ConfigurationItem> ReadRepository => Repository.ConfigurationItem;


    }
}
