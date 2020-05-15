namespace ProjectArcive_DIU.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sumittedby : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "SubmittedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "SubmittedBy");
        }
    }
}
