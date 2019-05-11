using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_KantinOtomasyonu.Models.Entities
{
    //Invoice de fatura numarasını ID olacak dıuşarıdan girilmesi için Baseentity den ID almadık
    public class InvoiceHeader
    {
        public InvoiceHeader()
        {
            this.invoiceDetails = new HashSet<InvoiceDetail>();
        }
        // dısarıdan ID deger girilmesi icin gerekli datatanotations 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public int SupplierID { get; set; }
        public DateTime InvoiceDate { get; set; }

        public string DeliveryNote { get; set; }

        public DateTime PaymentDate { get; set; }
        [DisplayFormat(NullDisplayText = "0.18")]
        public decimal? TotalAmount { get; set; }
        public virtual Supplier supplier { get; set; }
        public virtual ICollection<InvoiceDetail> invoiceDetails { get; set; }
    }
}
