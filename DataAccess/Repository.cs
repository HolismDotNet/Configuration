namespace Configuration;

public class Repository
{
    public static Write<Configuration.ConfigItem> ConfigItem
    {
        get
        {
            return new Write<Configuration.ConfigItem>(new ConfigurationContext());
        }
    }

    public static Write<Configuration.ConfigItemView> ConfigItemView
    {
        get
        {
            return new Write<Configuration.ConfigItemView>(new ConfigurationContext());
        }
    }

    public static Write<Configuration.EntityConfigItem> EntityConfigItem
    {
        get
        {
            return new Write<Configuration.EntityConfigItem>(new ConfigurationContext());
        }
    }

    public static Write<Configuration.EntityConfigItemView> EntityConfigItemView
    {
        get
        {
            return new Write<Configuration.EntityConfigItemView>(new ConfigurationContext());
        }
    }

    public static Write<Configuration.EntityConfig> EntityConfig
    {
        get
        {
            return new Write<Configuration.EntityConfig>(new ConfigurationContext());
        }
    }

    public static Write<Configuration.EntityConfigView> EntityConfigView
    {
        get
        {
            return new Write<Configuration.EntityConfigView>(new ConfigurationContext());
        }
    }

    public static Write<Configuration.EntityTypeConfig> EntityTypeConfig
    {
        get
        {
            return new Write<Configuration.EntityTypeConfig>(new ConfigurationContext());
        }
    }

    public static Write<Configuration.EntityTypeConfigView> EntityTypeConfigView
    {
        get
        {
            return new Write<Configuration.EntityTypeConfigView>(new ConfigurationContext());
        }
    }

    public static Write<Configuration.Option> Option
    {
        get
        {
            return new Write<Configuration.Option>(new ConfigurationContext());
        }
    }

    public static Write<Configuration.SystemConfig> SystemConfig
    {
        get
        {
            return new Write<Configuration.SystemConfig>(new ConfigurationContext());
        }
    }

    public static Write<Configuration.SystemConfigView> SystemConfigView
    {
        get
        {
            return new Write<Configuration.SystemConfigView>(new ConfigurationContext());
        }
    }

    public static Write<Configuration.UserConfigItem> UserConfigItem
    {
        get
        {
            return new Write<Configuration.UserConfigItem>(new ConfigurationContext());
        }
    }

    public static Write<Configuration.UserConfig> UserConfig
    {
        get
        {
            return new Write<Configuration.UserConfig>(new ConfigurationContext());
        }
    }

    public static Write<Configuration.UserConfigView> UserConfigView
    {
        get
        {
            return new Write<Configuration.UserConfigView>(new ConfigurationContext());
        }
    }
}
