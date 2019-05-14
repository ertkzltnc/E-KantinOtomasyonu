namespace E_KantinOtomasyonu.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Canteens", "CanteenName", c => c.String(nullable: false));
            AlterColumn("dbo.Canteens", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Canteens", "Location", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Canteens", "Location", c => c.String());
            AlterColumn("dbo.Canteens", "Phone", c => c.String());
            AlterColumn("dbo.Canteens", "CanteenName", c => c.String());
        }
    }
}
