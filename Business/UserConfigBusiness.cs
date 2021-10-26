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
    public class UserConfigBusiness : Business<UserConfigView, UserConfig>
    {
        protected override Repository<UserConfig> WriteRepository =>
            Repository.UserConfig;

        protected override ReadRepository<UserConfigView> ReadRepository =>
            Repository.UserConfigView;

        public UserConfigView SetValue(long id, object value, Guid userGuid)
        {
            var userConfig = WriteRepository.Get(id);
            if (userConfig.UserGuid != userGuid) 
            {
                throw new ClientException("Configuration item does not belong to the user");
            }
            userConfig.CurrentValue = value.ToString();
            Update(userConfig);
            return Get(id);
        }
    }
}
