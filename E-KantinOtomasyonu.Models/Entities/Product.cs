using E_KantinOtomasyonu.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_KantinOtomasyonu.Models.Entities
{
    public class Product:BaseEntity<int>
    {
        public Product()
        {
            this.orderDetails = new HashSet<OrderDetail>();
            this.invoiceDetails = new HashSet<InvoiceDetail>();
            this.canteenStocks = new HashSet<CanteenStock>();
        }
        public int UnitID { get; set; }
        public string ProductName { get; set; }
        public byte[] Image { get; set; }

        public decimal UnitPrice { get; set; }
        public virtual Unit unit { get; set; }
        public ICollection<CanteenStock> canteenStocks { get; set; }
        public ICollection<OrderDetail> orderDetails { get; set; }
        public ICollection<InvoiceDetail> invoiceDetails { get; set; }

    }
}
