using Holism.Api;
using Holism.Business;
using Holism.Configuration.Business;
using Holism.Configuration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Holism.Configuration.AdminApi
{
    public class ConfigTypeController : EnumController<Models.Type>
    {
        public override EnumBusiness<Models.Type> EnumBusiness => new TypeBusiness();
    }
}
