using E_KantinOtomasyonu.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_KantinOtomasyonu.Models.Entities
{
    public class OrderDetail:BaseEntity2<int,int>
    {
        public decimal UnitPrice { get; set; }
        public double Quantity { get; set; }
        public virtual OrderHeader OrderHeader { get; set; }
        public virtual Product product { get; set; }
    }
}
