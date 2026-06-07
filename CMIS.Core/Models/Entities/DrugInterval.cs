using System.ComponentModel.DataAnnotations;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    public class DrugInterval
    {
        [Key]
        public int DrugIntervalID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(10)]
        [Display(Name = "Interval code")]
        [DataType(DataType.Text)]
        public string IntervalCode { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Interval")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public int? NumericInterpretation { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<Medication> Medications { get; set; }
    }
}