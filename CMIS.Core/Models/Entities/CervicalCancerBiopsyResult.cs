using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("CervicalCancerBiopsyResult")]
    public class CervicalCancerBiopsyResult
    {
        [Key]
        public int CervicalCancerBiopsyResultID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Biopsy result")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<CervicalCancer> CervicalCancers { get; set; }
    }
}