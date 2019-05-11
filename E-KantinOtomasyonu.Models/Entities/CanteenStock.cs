using E_KantinOtomasyonu.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_KantinOtomasyonu.Models.Entities
{
    public class CanteenStock:BaseEntity2<int,int>
    {
        public int Quantity { get; set; }
        public virtual Canteen canteen { get; set; }

        public virtual Product product { get; set; }
    }
}
