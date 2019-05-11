using E_KantinOtomasyonu.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_KantinOtomasyonu.Models.Entities
{
    public class Unit:BaseEntity<int>
    {
        public Unit()
        {
            this.products = new HashSet<Product>();

        }

        public string UnitName { get; set; }
        public virtual ICollection<Product> products { get; set; }
    }
}
