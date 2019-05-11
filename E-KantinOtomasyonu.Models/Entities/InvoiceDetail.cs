using E_KantinOtomasyonu.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_KantinOtomasyonu.Models.Entities
{
    public class InvoiceDetail:BaseEntity2<int,int>
    {
        public int Quantity { get; set; }

        public double UnitPrice { get; set; }
        public double TotalAmount { get; set; }

        public string Description { get; set; }
        public virtual Product product { get; set; }

        public virtual InvoiceHeader invoiceHeader { get; set; }

    }
}
