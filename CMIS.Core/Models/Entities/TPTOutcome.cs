using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("TPTOutcome")]
    public class TPTOutcome
    {
        [Key]
        public int TPTOutcomeID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "TPT outcome")]
        public string Description { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<TPT> TPT { get; set; }
    }
}
