namespace E_KantinOtomasyonu.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderDetails", new[] { "orderDetail_ID", "orderDetail_ID2" }, "dbo.OrderDetails");
            DropIndex("dbo.OrderDetails", new[] { "orderDetail_ID", "orderDetail_ID2" });
            DropColumn("dbo.OrderDetails", "orderDetail_ID");
            DropColumn("dbo.OrderDetails", "orderDetail_ID2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderDetails", "orderDetail_ID2", c => c.Int());
            AddColumn("dbo.OrderDetails", "orderDetail_ID", c => c.Int());
            CreateIndex("dbo.OrderDetails", new[] { "orderDetail_ID", "orderDetail_ID2" });
            AddForeignKey("dbo.OrderDetails", new[] { "orderDetail_ID", "orderDetail_ID2" }, "dbo.OrderDetails", new[] { "ID", "ID2" });
        }
    }
}
