using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Territories")]
    public class Territory
    {
        [Key]
        public int TerritoryID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Territory Description cannot be more than 50 characters long")]
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; } //fk to "regions" table


        public virtual Region Region { get; set; }
        public virtual ICollection<EmployeeTerritory> EmployeeTerritories { get; set; } =
            new HashSet<EmployeeTerritory>();
    }
}
