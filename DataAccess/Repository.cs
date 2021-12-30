namespace Holism.Configuration.DataAccess;

public class Repository
{
    public static Repository<ConfigItem> ConfigItem
    {
        get
        {
            return new Repository<ConfigItem>(new ConfigurationContext());
        }
    }

    public static Repository<ConfigItemView> ConfigItemView
    {
        get
        {
            return new Repository<ConfigItemView>(new ConfigurationContext());
        }
    }

    public static Repository<EntityConfigItem> EntityConfigItem
    {
        get
        {
            return new Repository<EntityConfigItem>(new ConfigurationContext());
        }
    }

    public static Repository<EntityConfigItemView> EntityConfigItemView
    {
        get
        {
            return new Repository<EntityConfigItemView>(new ConfigurationContext());
        }
    }

    public static Repository<EntityConfig> EntityConfig
    {
        get
        {
            return new Repository<EntityConfig>(new ConfigurationContext());
        }
    }

    public static Repository<EntityConfigView> EntityConfigView
    {
        get
        {
            return new Repository<EntityConfigView>(new ConfigurationContext());
        }
    }

    public static Repository<EntityTypeConfig> EntityTypeConfig
    {
        get
        {
            return new Repository<EntityTypeConfig>(new ConfigurationContext());
        }
    }

    public static Repository<Option> Option
    {
        get
        {
            return new Repository<Option>(new ConfigurationContext());
        }
    }

    public static Repository<SystemConfig> SystemConfig
    {
        get
        {
            return new Repository<SystemConfig>(new ConfigurationContext());
        }
    }

    public static Repository<SystemConfigView> SystemConfigView
    {
        get
        {
            return new Repository<SystemConfigView>(new ConfigurationContext());
        }
    }

    public static Repository<UserConfigItem> UserConfigItem
    {
        get
        {
            return new Repository<UserConfigItem>(new ConfigurationContext());
        }
    }

    public static Repository<UserConfig> UserConfig
    {
        get
        {
            return new Repository<UserConfig>(new ConfigurationContext());
        }
    }

    public static Repository<UserConfigView> UserConfigView
    {
        get
        {
            return new Repository<UserConfigView>(new ConfigurationContext());
        }
    }
}
