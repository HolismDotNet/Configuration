using Holism.Api;
using Holism.Business;
using Holism.Configuration.Business;
using Holism.Configuration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Holism.Configuration.AdminApi
{
    public class ConfigTypeController : EnumController<Type>
    {
        public override EnumBusiness<Type> EnumBusiness => new TypeBusiness();
    }
}
