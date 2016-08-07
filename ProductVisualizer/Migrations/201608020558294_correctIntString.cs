namespace ProductVisualizer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correctIntString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BIMUses", "BIMUseName", c => c.String());
            AlterColumn("dbo.disciplines", "DisciplineName", c => c.String());
            AlterColumn("dbo.GEOs", "GEOName", c => c.String());
            AlterColumn("dbo.MarketSectors", "MarketSectorName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MarketSectors", "MarketSectorName", c => c.Int(nullable: false));
            AlterColumn("dbo.GEOs", "GEOName", c => c.Int(nullable: false));
            AlterColumn("dbo.disciplines", "DisciplineName", c => c.Int(nullable: false));
            AlterColumn("dbo.BIMUses", "BIMUseName", c => c.Int(nullable: false));
        }
    }
}
