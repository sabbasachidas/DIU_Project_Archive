namespace ProjectArcive_DIU.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contactdevlper : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "ContactOfDeveloper", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "ContactOfDeveloper");
        }
    }
}
