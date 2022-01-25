namespace Configuration;

public class ConfigurationContext : DatabaseContext
{
    public override string ConnectionStringName => "Configuration";

    public DbSet<Configuration.ConfigItem> ConfigItems { get; set; }

    public DbSet<Configuration.ConfigItemView> ConfigItemViews { get; set; }

    public DbSet<Configuration.EntityConfigItem> EntityConfigItems { get; set; }

    public DbSet<Configuration.EntityConfigItemView> EntityConfigItemViews { get; set; }

    public DbSet<Configuration.EntityConfig> EntityConfigs { get; set; }

    public DbSet<Configuration.EntityConfigView> EntityConfigViews { get; set; }

    public DbSet<Configuration.EntityTypeConfig> EntityTypeConfigs { get; set; }

    public DbSet<Configuration.Option> Options { get; set; }

    public DbSet<Configuration.SystemConfig> SystemConfigs { get; set; }

    public DbSet<Configuration.SystemConfigView> SystemConfigViews { get; set; }

    public DbSet<Configuration.UserConfigItem> UserConfigItems { get; set; }

    public DbSet<Configuration.UserConfig> UserConfigs { get; set; }

    public DbSet<Configuration.UserConfigView> UserConfigViews { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
