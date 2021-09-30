using Holism.Configuration.Models;
using Holism.DataAccess;

namespace Holism.Configuration.DataAccess
{
    public class Repository
    {
        public static Repository<Option> Option
        {
            get
            {
                return new Holism.DataAccess.Repository<Option
                >(new ConfigurationContext());
            }
        }

        public static Repository<SystemConfig> SystemConfig
        {
            get
            {
                return new Holism.DataAccess.Repository<SystemConfig
                >(new ConfigurationContext());
            }
        }

        public static Repository<UserConfig> UserConfig
        {
            get
            {
                return new Holism.DataAccess.Repository<UserConfig
                >(new ConfigurationContext());
            }
        }

        public static Repository<EntityTypeConfig> EntityTypeConfig
        {
            get
            {
                return new Holism.DataAccess.Repository<EntityTypeConfig
                >(new ConfigurationContext());
            }
        }

        public static Repository<EntityConfig> EntityConfig
        {
            get
            {
                return new Holism.DataAccess.Repository<EntityConfig
                >(new ConfigurationContext());
            }
        }
    }
}
