namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correctTableCoach : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Coaches", "BirthDay", c => c.String());
            AlterColumn("dbo.Coaches", "WorkTIme", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Coaches", "WorkTIme", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Coaches", "BirthDay", c => c.DateTime(nullable: false));
        }
    }
}
