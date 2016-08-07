namespace ProductVisualizer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TasksAndComments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TaskId = c.Int(nullable: false, identity: true),
                        BIMUseId = c.Int(nullable: false),
                        TaskName = c.String(),
                    })
                .PrimaryKey(t => t.TaskId)
                .ForeignKey("dbo.BIMUses", t => t.BIMUseId, cascadeDelete: true)
                .Index(t => t.BIMUseId);
            
            AddColumn("dbo.Linkers", "comments", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "BIMUseId", "dbo.BIMUses");
            DropIndex("dbo.Tasks", new[] { "BIMUseId" });
            DropColumn("dbo.Linkers", "comments");
            DropTable("dbo.Tasks");
        }
    }
}
