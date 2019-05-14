using E_KantinOtomasyonu.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_KantinOtomasyonu.Models.Entities
{
    public class Canteen:BaseEntity<int>
    {
        public Canteen()
        {
            this.canteenStocks = new HashSet<CanteenStock>();
        }
        [Required]
        public string CanteenName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Location { get; set; }
        public ICollection<CanteenStock> canteenStocks { get; set; }
    }
}
