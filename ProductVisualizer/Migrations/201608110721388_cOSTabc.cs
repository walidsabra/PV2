namespace ProductVisualizer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cOSTabc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.softwares", "CostABC", c => c.String());
            DropColumn("dbo.softwares", "Cost");
        }
        
        public override void Down()
        {
            AddColumn("dbo.softwares", "Cost", c => c.String());
            DropColumn("dbo.softwares", "CostABC");
        }
    }
}
