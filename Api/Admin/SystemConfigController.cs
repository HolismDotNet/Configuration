using Holism.Api;
using Holism.Business;
using Holism.Configuration.Business;
using Holism.Configuration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Holism.Configuration.AdminApi
{
    public class SystemConfigController : Controller<SystemConfigView, SystemConfig>
    {
        public override ReadBusiness<SystemConfigView> ReadBusiness => new SystemConfigBusiness();
        
        public override Business<SystemConfigView, SystemConfig> Business => new SystemConfigBusiness();

        [HttpPost]
        public IActionResult SetValue(long id, object value)
        {
            new SystemConfigBusiness().SetValue(id, value);
            return OkJson();
        }
    }
}
