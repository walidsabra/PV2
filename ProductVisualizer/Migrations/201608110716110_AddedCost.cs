namespace ProductVisualizer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.softwares", "Cost", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.softwares", "Cost");
        }
    }
}
