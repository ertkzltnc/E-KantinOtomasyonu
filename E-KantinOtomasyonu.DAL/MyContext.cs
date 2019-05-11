namespace E_KantinOtomasyonu.DAL
{
    using E_KantinOtomasyonu.Models.Entities;
    using E_KantinOtomasyonu.Models.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyContext : IdentityDbContext<User>
    {
        
        public MyContext()
            : base("name=MyContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<Canteen> Canteen { get; set; }
        public virtual DbSet<CanteenStock> CanteenStock { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public virtual DbSet<InvoiceHeader> InvoiceHeader { get; set; }
        public virtual DbSet<MeetingRoom> MeetingRoom { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<OrderHeader> OrderHeader { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
    }

    
}