using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using MVCRouting.Data.Models;

namespace MVCRouting.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataConnectionString")
        {
            
        }

        public DbSet<OneKeyServer> OneKeyServers { get; set; }
        public DbSet<RouteConfiguration> RouteConfigurations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}