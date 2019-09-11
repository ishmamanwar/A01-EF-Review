using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("ManifestItems")]
    public class ManifestItem
    {
        [Key]
        public int ManifestItemID { get; set; }
        public int ShipmentID { get; set; } //fk to "shipments" table
        public int ProductID { get; set; } //fk to "products" table
        public int ShipQuantity { get; set; }


    }
}
