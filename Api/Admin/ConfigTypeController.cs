namespace Holism.Configuration.AdminApi;

public class ConfigTypeController : EnumController<Models.Type>
{
    public override EnumBusiness<Models.Type> EnumBusiness => new TypeBusiness();
}
