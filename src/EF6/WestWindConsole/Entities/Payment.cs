using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Payments")]
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public int PaymentTypeID { get; set; } //fk to "Payment Types" table
        public int OrderID { get; set; } //fk to "orders" table
        public System.Guid TransactionID { get; set; }
        public DateTime? ClearedDate { get; set; }



    }
}
