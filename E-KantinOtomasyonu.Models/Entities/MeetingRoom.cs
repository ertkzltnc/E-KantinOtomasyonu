using E_KantinOtomasyonu.Models.Abstracts;
using E_KantinOtomasyonu.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_KantinOtomasyonu.Models.Entities
{
    public class MeetingRoom:BaseEntity<int>
    {
        /*Identity eklendiği zaman yazılacak*/
        public MeetingRoom()
        {
            this.users = new HashSet<User>();
        }
        public string MeetingRoomName { get; set; }
        public decimal MonthlyLimit { get; set; }
        public ICollection<User> users { get; set; }

    }
}
