using Holism.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Holism.Configuration.Models;

namespace Holism.Configuration.DataAccess
{
    public class ConfigurationContext : DatabaseContext
    {
        public override string ConnectionStringName => "Configuration";

        public DbSet<ConfigurationItem> ConfigurationItems { get; set; }
        public DbSet<Option> Options {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<ConfigurationItem>().Property(i => i.Id).ValueGeneratedNever();
			modelBuilder.Entity<Option>().Property(i => i.Id).ValueGeneratedNever();
            base.OnModelCreating(modelBuilder);
        }
    }
}
