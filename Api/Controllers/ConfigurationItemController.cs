
using Holism.Api.Controllers;
using Holism.Business;
using Holism.Configuration.Business;

namespace Holism.Configuration.Api.Controllers
{
    public class ConfigurationItemController : ReadController<ConfigurationItem>
    {
        public override ReadBusiness<ConfigurationItem> ReadBusiness => new ConfigurationItemBusiness();
    }
}
