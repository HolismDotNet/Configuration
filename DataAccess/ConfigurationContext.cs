using System.Collections.Generic;
using Holism.Configuration.Models;
using Holism.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Holism.Configuration.DataAccess
{
    public class ConfigurationContext : DatabaseContext
    {
        public override string ConnectionStringName => "Configuration";

        public DbSet<ConfigItem> ConfigItems { get; set; }

        public DbSet<Option> Options { get; set; }

        public DbSet<SystemConfig> SystemConfigs { get; set; }

        public DbSet<UserConfigItem> UserConfigItems { get; set; }

        public DbSet<UserConfig> UserConfigs { get; set; }

        public DbSet<EntityTypeConfig> EntityTypeConfigs { get; set; }

        public DbSet<EntityConfig> EntityConfigs { get; set; }

        public DbSet<ConfigItemView> ConfigItemViews { get; set; }

        public DbSet<SystemConfigView> SystemConfigViews { get; set; }

        public DbSet<UserConfigView> UserConfigViews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
