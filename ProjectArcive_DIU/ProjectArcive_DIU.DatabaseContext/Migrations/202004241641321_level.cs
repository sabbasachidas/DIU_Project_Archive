namespace ProjectArcive_DIU.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class level : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Level", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "Level");
        }
    }
}
