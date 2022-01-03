using Holism.Configuration.DataAccess;
using Holism.Configuration.Models;

namespace Holism.Configuration.Business;

public class ConfigTypeBusiness : EnumBusiness<ConfigType>
{
    public override string ConnectionString => Repository.ConfigItem.ConnectionString;
}
