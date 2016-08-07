namespace ProductVisualizer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLinker : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Linkers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SoftwareId = c.Int(nullable: false),
                        ObjectId = c.Int(nullable: false),
                        ObjectType = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.softwares", t => t.SoftwareId, cascadeDelete: true)
                .Index(t => t.SoftwareId);
            
            AlterColumn("dbo.Phases", "PhaseName", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Linkers", "SoftwareId", "dbo.softwares");
            DropIndex("dbo.Linkers", new[] { "SoftwareId" });
            AlterColumn("dbo.Phases", "PhaseName", c => c.Int(nullable: false));
            DropTable("dbo.Linkers");
        }
    }
}
