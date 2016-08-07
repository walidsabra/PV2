namespace ProductVisualizer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BIMUses",
                c => new
                    {
                        BIMUseId = c.Int(nullable: false, identity: true),
                        BIMUseName = c.Int(nullable: false),
                        software_SoftwareId = c.Int(),
                    })
                .PrimaryKey(t => t.BIMUseId)
                .ForeignKey("dbo.softwares", t => t.software_SoftwareId)
                .Index(t => t.software_SoftwareId);
            
            CreateTable(
                "dbo.disciplines",
                c => new
                    {
                        DisciplineId = c.Int(nullable: false, identity: true),
                        DisciplineName = c.Int(nullable: false),
                        software_SoftwareId = c.Int(),
                    })
                .PrimaryKey(t => t.DisciplineId)
                .ForeignKey("dbo.softwares", t => t.software_SoftwareId)
                .Index(t => t.software_SoftwareId);
            
            CreateTable(
                "dbo.GEOs",
                c => new
                    {
                        GEOId = c.Int(nullable: false, identity: true),
                        GEOName = c.Int(nullable: false),
                        software_SoftwareId = c.Int(),
                    })
                .PrimaryKey(t => t.GEOId)
                .ForeignKey("dbo.softwares", t => t.software_SoftwareId)
                .Index(t => t.software_SoftwareId);
            
            CreateTable(
                "dbo.MarketSectors",
                c => new
                    {
                        MarketSectorId = c.Int(nullable: false, identity: true),
                        MarketSectorName = c.Int(nullable: false),
                        software_SoftwareId = c.Int(),
                    })
                .PrimaryKey(t => t.MarketSectorId)
                .ForeignKey("dbo.softwares", t => t.software_SoftwareId)
                .Index(t => t.software_SoftwareId);
            
            CreateTable(
                "dbo.Phases",
                c => new
                    {
                        PhaseId = c.Int(nullable: false, identity: true),
                        PhaseName = c.Int(nullable: false),
                        software_SoftwareId = c.Int(),
                    })
                .PrimaryKey(t => t.PhaseId)
                .ForeignKey("dbo.softwares", t => t.software_SoftwareId)
                .Index(t => t.software_SoftwareId);
            
            CreateTable(
                "dbo.softwares",
                c => new
                    {
                        SoftwareId = c.Int(nullable: false, identity: true),
                        SoftwareName = c.String(),
                        Description = c.String(),
                        ProductPage = c.String(),
                        TokenRate = c.String(),
                        LearnIt = c.String(),
                    })
                .PrimaryKey(t => t.SoftwareId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phases", "software_SoftwareId", "dbo.softwares");
            DropForeignKey("dbo.MarketSectors", "software_SoftwareId", "dbo.softwares");
            DropForeignKey("dbo.GEOs", "software_SoftwareId", "dbo.softwares");
            DropForeignKey("dbo.disciplines", "software_SoftwareId", "dbo.softwares");
            DropForeignKey("dbo.BIMUses", "software_SoftwareId", "dbo.softwares");
            DropIndex("dbo.Phases", new[] { "software_SoftwareId" });
            DropIndex("dbo.MarketSectors", new[] { "software_SoftwareId" });
            DropIndex("dbo.GEOs", new[] { "software_SoftwareId" });
            DropIndex("dbo.disciplines", new[] { "software_SoftwareId" });
            DropIndex("dbo.BIMUses", new[] { "software_SoftwareId" });
            DropTable("dbo.softwares");
            DropTable("dbo.Phases");
            DropTable("dbo.MarketSectors");
            DropTable("dbo.GEOs");
            DropTable("dbo.disciplines");
            DropTable("dbo.BIMUses");
        }
    }
}
