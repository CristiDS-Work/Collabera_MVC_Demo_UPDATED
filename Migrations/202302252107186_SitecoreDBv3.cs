namespace SitecorePoweredBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SitecoreDBv3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Tags", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Tags");
        }
    }
}
