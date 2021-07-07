using Holism.Configuration.Models;
using Holism.DataAccess;

namespace Holism.Configuration.DataAccess
{
    public class Repository
    {
        public static Repository<ConfigurationItem> ConfigurationItem
        {
            get
            {
                return new Holism.DataAccess.Repository<ConfigurationItem>(new ConfigurationContext());
            }
        }

        public static Repository<Option> Option
        {
            get
            {
                return new Holism.DataAccess.Repository<Option>(new ConfigurationContext());
            }
        }
    }
}
