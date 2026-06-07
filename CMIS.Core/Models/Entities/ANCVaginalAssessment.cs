using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("ANCVaginalAssessment")]
    public class ANCVaginalAssessment
    {
        [Key]
        public int ANCVaginalAssessmentID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Vaginal assessment")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<ANCClientVaginalAssessment> ANCClientVaginalAssessment { get; set; }
    }
}
