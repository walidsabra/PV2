namespace ProductVisualizer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TasksIndex : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "software_SoftwareId", c => c.Int());
            CreateIndex("dbo.Tasks", "software_SoftwareId");
            AddForeignKey("dbo.Tasks", "software_SoftwareId", "dbo.softwares", "SoftwareId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "software_SoftwareId", "dbo.softwares");
            DropIndex("dbo.Tasks", new[] { "software_SoftwareId" });
            DropColumn("dbo.Tasks", "software_SoftwareId");
        }
    }
}
