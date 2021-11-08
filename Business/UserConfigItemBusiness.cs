using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Holism.Business;
using Holism.Configuration.DataAccess;
using Holism.Configuration.Models;
using Holism.DataAccess;
using Holism.Infra;
using Microsoft.VisualBasic;
using MoreLinq;

namespace Holism.Configuration.Business
{
    public class UserConfigItemBusiness : Business<UserConfigItem, UserConfigItem>
    {
        protected override Repository<UserConfigItem> WriteRepository =>
            Repository.UserConfigItem;

        protected override ReadRepository<UserConfigItem> ReadRepository =>
            Repository.UserConfigItem;
    }
}
