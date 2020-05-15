namespace ProjectArcive_DIU.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class supervised : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "SupervisedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "SupervisedBy");
        }
    }
}
