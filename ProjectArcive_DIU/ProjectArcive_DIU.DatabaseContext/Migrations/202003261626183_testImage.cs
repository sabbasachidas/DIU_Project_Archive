namespace ProjectArcive_DIU.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "ScreenShotBytes", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "ScreenShotBytes");
        }
    }
}
