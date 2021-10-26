using Holism.Api;
using Holism.Business;
using Holism.Configuration.Business;
using Holism.Configuration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Holism.Configuration.AdminApi
{
    public class ConfigItemController : Controller<ConfigItemView, ConfigItem>
    {
        public override ReadBusiness<ConfigItemView> ReadBusiness => new ConfigItemBusiness();
        
        public override Business<ConfigItemView, ConfigItem> Business => new ConfigItemBusiness();
    }
}
