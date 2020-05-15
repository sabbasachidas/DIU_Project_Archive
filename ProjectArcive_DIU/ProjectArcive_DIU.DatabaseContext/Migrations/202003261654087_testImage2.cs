namespace ProjectArcive_DIU.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testImage2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Image", c => c.Binary());
            DropColumn("dbo.Projects", "ScreenShotBytes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projects", "ScreenShotBytes", c => c.Binary());
            DropColumn("dbo.Projects", "Image");
        }
    }
}
