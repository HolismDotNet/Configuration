using Holism.Configuration.Models;
using Holism.DataAccess;

namespace Holism.Configuration.DataAccess
{
    public class Repository
    {
        public static Repository<ConfigItem> ConfigItem
        {
            get
            {
                return new Holism.DataAccess.Repository<ConfigItem
                >(new ConfigurationContext());
            }
        }

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

        public static Repository<UserConfigItem> UserConfigItem
        {
            get
            {
                return new Holism.DataAccess.Repository<UserConfigItem
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

        public static Repository<EntityConfigItem> EntityConfigItem
        {
            get
            {
                return new Holism.DataAccess.Repository<EntityConfigItem
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

        public static Repository<ConfigItemView> ConfigItemView
        {
            get
            {
                return new Holism.DataAccess.Repository<ConfigItemView
                >(new ConfigurationContext());
            }
        }

        public static Repository<SystemConfigView> SystemConfigView
        {
            get
            {
                return new Holism.DataAccess.Repository<SystemConfigView
                >(new ConfigurationContext());
            }
        }

        public static Repository<UserConfigView> UserConfigView
        {
            get
            {
                return new Holism.DataAccess.Repository<UserConfigView
                >(new ConfigurationContext());
            }
        }

        public static Repository<EntityConfigView> EntityConfigView
        {
            get
            {
                return new Holism.DataAccess.Repository<EntityConfigView
                >(new ConfigurationContext());
            }
        }

        public static Repository<EntityConfigItemView> EntityConfigItemView
        {
            get
            {
                return new Holism.DataAccess.Repository<EntityConfigItemView
                >(new ConfigurationContext());
            }
        }
    }
}
