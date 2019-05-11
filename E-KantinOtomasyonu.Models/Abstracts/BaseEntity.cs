using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_KantinOtomasyonu.Models.Abstracts
{
    public abstract class BaseEntity<T>
    {
        [Key]
        [Column(Order = 1)]
        public T ID { get; set; }
    }
}
