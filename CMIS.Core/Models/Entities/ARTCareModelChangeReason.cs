using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("ARTCareModelChangeReason")]
    public class ARTCareModelChangeReason
    {
        [Key]
        public int ARTCareModelChangeReasonID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Functional status")]
        public string Description { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<ART> ART { get; set; }
    }
}
