using Holism.Api.Controllers;
using Holism.Business;
using Holism.Configuration.Business;
using Holism.Configuration.Models;


namespace Holism.Configuration.Api.Controllers
{
    public class OptionController : ReadController<Option>
    {
        public override ReadBusiness<Option> ReadBusiness => new OptionBusiness();
    }
}

