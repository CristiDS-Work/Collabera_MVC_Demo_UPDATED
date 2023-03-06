namespace SitecorePoweredBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SitecoreDBv2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Category", c => c.String());
            AddColumn("dbo.Blogs", "SmallImage", c => c.String());
            AddColumn("dbo.Blogs", "BigImage", c => c.String());
            DropColumn("dbo.Blogs", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blogs", "Image", c => c.String());
            DropColumn("dbo.Blogs", "BigImage");
            DropColumn("dbo.Blogs", "SmallImage");
            DropColumn("dbo.Blogs", "Category");
        }
    }
}
