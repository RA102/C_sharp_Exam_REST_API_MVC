namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAlmostAllTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gyms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Capacity = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TimingTrainings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GymId = c.Int(nullable: false),
                        CoachId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Coaches", t => t.CoachId, cascadeDelete: true)
                .ForeignKey("dbo.Gyms", t => t.GymId, cascadeDelete: true)
                .ForeignKey("dbo.TypeTrainings", t => t.TypeId, cascadeDelete: true)
                .Index(t => t.GymId)
                .Index(t => t.CoachId)
                .Index(t => t.TypeId);
            
            CreateTable(
                "dbo.TypeTrainings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TimingTrainings", "TypeId", "dbo.TypeTrainings");
            DropForeignKey("dbo.TimingTrainings", "GymId", "dbo.Gyms");
            DropForeignKey("dbo.TimingTrainings", "CoachId", "dbo.Coaches");
            DropIndex("dbo.TimingTrainings", new[] { "TypeId" });
            DropIndex("dbo.TimingTrainings", new[] { "CoachId" });
            DropIndex("dbo.TimingTrainings", new[] { "GymId" });
            DropTable("dbo.TypeTrainings");
            DropTable("dbo.TimingTrainings");
            DropTable("dbo.Gyms");
        }
    }
}
