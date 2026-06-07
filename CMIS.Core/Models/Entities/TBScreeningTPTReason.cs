using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("TBScreeningTPTReason")]
    public class TBScreeningTPTReason
    {
        [Key]
        public int TBScreeningTPTReasonID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "TPT Reason")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<TBScreening> TBScreenings { get; set; }
    }
}
