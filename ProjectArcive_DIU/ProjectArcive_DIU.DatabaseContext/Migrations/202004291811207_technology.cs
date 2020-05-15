namespace ProjectArcive_DIU.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class technology : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Technology", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "Technology");
        }
    }
}
