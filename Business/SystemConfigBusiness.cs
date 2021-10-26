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
    public class SystemConfigBusiness : Business<SystemConfigView, SystemConfig>
    {
        protected override Repository<SystemConfig> WriteRepository =>
            Repository.SystemConfig;

        protected override ReadRepository<SystemConfigView> ReadRepository =>
            Repository.SystemConfigView;

        public SystemConfigView SetValue(long id, object value)
        {
            var systemConfig = WriteRepository.Get(id);
            systemConfig.CurrentValue = value.ToString();
            Update(systemConfig);
            return Get(id);
        }
    }
}
