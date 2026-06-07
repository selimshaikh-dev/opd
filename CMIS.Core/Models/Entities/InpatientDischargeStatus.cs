using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("InpatientDischargeStatus")]
    public class InpatientDischargeStatus
    {
        [Key]
        public int InpatientDischargeStatusID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(30)]
        [Display(Name = "Discharge status")]
        public string Description { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<InpatientAdmission> InpatientAdmission { get; set; }
    }
}
