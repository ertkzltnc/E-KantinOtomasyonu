namespace E_KantinOtomasyonu.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Canteens",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CanteenName = c.String(),
                        Phone = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CanteenStocks",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        ID2 = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID, t.ID2 })
                .ForeignKey("dbo.Canteens", t => t.ID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ID, cascadeDelete: true)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UnitID = c.Int(nullable: false),
                        ProductName = c.String(),
                        Image = c.Binary(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Units", t => t.UnitID, cascadeDelete: true)
                .Index(t => t.UnitID);
            
            CreateTable(
                "dbo.InvoiceDetails",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        ID2 = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        TotalAmount = c.Double(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => new { t.ID, t.ID2 })
                .ForeignKey("dbo.InvoiceHeaders", t => t.ID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ID, cascadeDelete: true)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.InvoiceHeaders",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        SupplierID = c.Int(nullable: false),
                        InvoiceDate = c.DateTime(nullable: false),
                        DeliveryNote = c.String(),
                        PaymentDate = c.DateTime(nullable: false),
                        TotalAmount = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Suppliers", t => t.SupplierID, cascadeDelete: true)
                .Index(t => t.SupplierID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Adress = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        ID2 = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Double(nullable: false),
                        orderDetail_ID = c.Int(),
                        orderDetail_ID2 = c.Int(),
                    })
                .PrimaryKey(t => new { t.ID, t.ID2 })
                .ForeignKey("dbo.OrderDetails", t => new { t.orderDetail_ID, t.orderDetail_ID2 })
                .ForeignKey("dbo.Products", t => t.ID, cascadeDelete: true)
                .ForeignKey("dbo.OrderHeaders", t => t.ID, cascadeDelete: true)
                .Index(t => t.ID)
                .Index(t => new { t.orderDetail_ID, t.orderDetail_ID2 });
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UnitName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MeetingRooms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MeetingRoomName = c.String(),
                        MonthlyLimit = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Surname = c.String(),
                        Wage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        meetingRoom_ID = c.Int(),
                        user_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MeetingRooms", t => t.meetingRoom_ID)
                .ForeignKey("dbo.AspNetUsers", t => t.user_Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex")
                .Index(t => t.meetingRoom_ID)
                .Index(t => t.user_Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.OrderHeaders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CanteenID = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        user_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Canteens", t => t.CanteenID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.user_Id)
                .Index(t => t.CanteenID)
                .Index(t => t.user_Id);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Description = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUsers", "user_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.OrderHeaders", "user_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.OrderDetails", "ID", "dbo.OrderHeaders");
            DropForeignKey("dbo.OrderHeaders", "CanteenID", "dbo.Canteens");
            DropForeignKey("dbo.AspNetUsers", "meetingRoom_ID", "dbo.MeetingRooms");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Products", "UnitID", "dbo.Units");
            DropForeignKey("dbo.OrderDetails", "ID", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", new[] { "orderDetail_ID", "orderDetail_ID2" }, "dbo.OrderDetails");
            DropForeignKey("dbo.InvoiceDetails", "ID", "dbo.Products");
            DropForeignKey("dbo.InvoiceHeaders", "SupplierID", "dbo.Suppliers");
            DropForeignKey("dbo.InvoiceDetails", "ID", "dbo.InvoiceHeaders");
            DropForeignKey("dbo.CanteenStocks", "ID", "dbo.Products");
            DropForeignKey("dbo.CanteenStocks", "ID", "dbo.Canteens");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.OrderHeaders", new[] { "user_Id" });
            DropIndex("dbo.OrderHeaders", new[] { "CanteenID" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", new[] { "user_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "meetingRoom_ID" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.OrderDetails", new[] { "orderDetail_ID", "orderDetail_ID2" });
            DropIndex("dbo.OrderDetails", new[] { "ID" });
            DropIndex("dbo.InvoiceHeaders", new[] { "SupplierID" });
            DropIndex("dbo.InvoiceDetails", new[] { "ID" });
            DropIndex("dbo.Products", new[] { "UnitID" });
            DropIndex("dbo.CanteenStocks", new[] { "ID" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.OrderHeaders");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.MeetingRooms");
            DropTable("dbo.Units");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Suppliers");
            DropTable("dbo.InvoiceHeaders");
            DropTable("dbo.InvoiceDetails");
            DropTable("dbo.Products");
            DropTable("dbo.CanteenStocks");
            DropTable("dbo.Canteens");
        }
    }
}
