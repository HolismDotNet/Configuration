using System;
using Holism.Infra;
using Holism.Api;
using Holism.Business;
using Holism.Configuration.Business;
using Holism.Configuration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Holism.Configuration.UserApi
{
    public class UserConfigController : ReadController<UserConfigView>
    {
        public override ReadBusiness<UserConfigView> ReadBusiness => new UserConfigBusiness();

        public override Action<ListParameters> ListParametersAugmenter =>
            listParameters =>
            {
                listParameters
                    .AddFilter<UserConfigView>(i => i.UserGuid,
                    UserGuid);
            };

        [HttpPost]
        public IActionResult SetValue(long id, object value)
        {
            // todo: ensure config belongs to the user
            new UserConfigBusiness().SetValue(id, value, UserGuid);
            return OkJson();
        }
    }
}
