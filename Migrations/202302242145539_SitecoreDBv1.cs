using System;
using System.Data.Entity.Migrations;

namespace SitecorePoweredBlog.Migrations
{
    public partial class SitecoreDBv1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Blog", newName: "Blogs");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Blogs", newName: "Blog");
        }
    }
}
