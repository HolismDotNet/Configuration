using Holism.Business;
using Holism.Configuration.DataAccess;
using Holism.Configuration.Models;

namespace Holism.Configuration.Business
{
    public class TypeBusiness : EnumBusiness<Type>
    {
        public override string ConnectionString =>
            Repository.ConfigItem.ConnectionString;
    }
}
