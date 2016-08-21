namespace ProductVisualizer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCostABC : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.softwares", "CostABC");
        }
        
        public override void Down()
        {
            AddColumn("dbo.softwares", "CostABC", c => c.String());
        }
    }
}
