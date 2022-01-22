namespace Configuration;

public class Repository
{
    public static Repository<Configuration.ConfigItem> ConfigItem
    {
        get
        {
            return new Repository<Configuration.ConfigItem>(new ConfigurationContext());
        }
    }

    public static Repository<Configuration.ConfigItemView> ConfigItemView
    {
        get
        {
            return new Repository<Configuration.ConfigItemView>(new ConfigurationContext());
        }
    }

    public static Repository<Configuration.EntityConfigItem> EntityConfigItem
    {
        get
        {
            return new Repository<Configuration.EntityConfigItem>(new ConfigurationContext());
        }
    }

    public static Repository<Configuration.EntityConfigItemView> EntityConfigItemView
    {
        get
        {
            return new Repository<Configuration.EntityConfigItemView>(new ConfigurationContext());
        }
    }

    public static Repository<Configuration.EntityConfig> EntityConfig
    {
        get
        {
            return new Repository<Configuration.EntityConfig>(new ConfigurationContext());
        }
    }

    public static Repository<Configuration.EntityConfigView> EntityConfigView
    {
        get
        {
            return new Repository<Configuration.EntityConfigView>(new ConfigurationContext());
        }
    }

    public static Repository<Configuration.EntityTypeConfig> EntityTypeConfig
    {
        get
        {
            return new Repository<Configuration.EntityTypeConfig>(new ConfigurationContext());
        }
    }

    public static Repository<Configuration.Option> Option
    {
        get
        {
            return new Repository<Configuration.Option>(new ConfigurationContext());
        }
    }

    public static Repository<Configuration.SystemConfig> SystemConfig
    {
        get
        {
            return new Repository<Configuration.SystemConfig>(new ConfigurationContext());
        }
    }

    public static Repository<Configuration.SystemConfigView> SystemConfigView
    {
        get
        {
            return new Repository<Configuration.SystemConfigView>(new ConfigurationContext());
        }
    }

    public static Repository<Configuration.UserConfigItem> UserConfigItem
    {
        get
        {
            return new Repository<Configuration.UserConfigItem>(new ConfigurationContext());
        }
    }

    public static Repository<Configuration.UserConfig> UserConfig
    {
        get
        {
            return new Repository<Configuration.UserConfig>(new ConfigurationContext());
        }
    }

    public static Repository<Configuration.UserConfigView> UserConfigView
    {
        get
        {
            return new Repository<Configuration.UserConfigView>(new ConfigurationContext());
        }
    }
}
