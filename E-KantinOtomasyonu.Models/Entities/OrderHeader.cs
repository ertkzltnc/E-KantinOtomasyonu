using E_KantinOtomasyonu.Models.Abstracts;
using E_KantinOtomasyonu.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_KantinOtomasyonu.Models.Entities
{
    public class OrderHeader : BaseEntity<int>
    {
        public OrderHeader()
        {
            this.orderDetails = new HashSet<OrderDetail>();
        }

        public int CanteenID { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual User user { get; set; }
        public virtual Canteen canteen { get; set; }
        public ICollection<OrderDetail> orderDetails { get; set; }


    }
}
