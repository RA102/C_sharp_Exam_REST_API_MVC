namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterTableCoachChangeBirthDay : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Coaches", "BirthDay", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Coaches", "WorkTIme", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Coaches", "WorkTIme", c => c.String());
            AlterColumn("dbo.Coaches", "BirthDay", c => c.String());
        }
    }
}
