
using Holism.Api.Controllers;
using Holism.Business;
using Holism.Configuration.Business;
using Holism.Configuration.Models;


namespace Holism.Configuration.Api.Controllers
{
    public class ConfigurationItemController : ReadController<ConfigurationItem>
    {
        public override ReadBusiness<ConfigurationItem> ReadBusiness => new ConfigurationItemBusiness();
    }
}
