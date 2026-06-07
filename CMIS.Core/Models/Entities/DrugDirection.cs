using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("DrugDirection")]
    public class DrugDirection
    {
        [Key]
        public int DrugDirectionID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(10)]
        [DataType(DataType.Text)]
        public string Code { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(300)]
        [Display(Name = "Drug direction")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<Medication> Medications { get; set; }
    }
}
