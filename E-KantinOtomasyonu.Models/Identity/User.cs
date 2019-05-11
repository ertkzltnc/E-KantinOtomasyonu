using E_KantinOtomasyonu.Models.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_KantinOtomasyonu.Models.Identity
{
    public class User:IdentityUser
    {
        public User()
        {
            this.orderHeaders = new HashSet<OrderHeader>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Wage { get; set; }
        public virtual User user { get; set; }
        public virtual MeetingRoom meetingRoom { get; set; }
        public ICollection<OrderHeader> orderHeaders { get; set; }
    }
}
