using E_KantinOtomasyonu.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_KantinOtomasyonu.Models.Entities
{
    public class Supplier:BaseEntity<int>
    {
        public Supplier()
        {
            this.invoiceHeaders = new HashSet<InvoiceHeader>();
        }
        public string CompanyName { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ICollection<InvoiceHeader> invoiceHeaders { get; set; }
    }
}
