using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SitecorePoweredBlog.Models;

namespace SitecorePoweredBlog.DAL
{
    public class SitecoreDBContext : DbContext
    {
        public SitecoreDBContext() : base("SitecoreDBContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SitecoreDBContext, SitecorePoweredBlog.Migrations.Configuration>());
        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}