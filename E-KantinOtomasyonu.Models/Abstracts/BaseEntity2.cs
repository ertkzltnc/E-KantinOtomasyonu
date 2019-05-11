using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_KantinOtomasyonu.Models.Abstracts
{
    public class BaseEntity2<T2,T1>:BaseEntity<T1>
    {
        [Key]
        [Column(Order = 2)]
        public T2 ID2 { get; set; }
    }
}
