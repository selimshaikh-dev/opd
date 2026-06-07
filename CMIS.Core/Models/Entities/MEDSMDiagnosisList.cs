using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("MEDSMDiagnosisList")]
    public class MEDSMDiagnosisList
    {
        [Key]
        public int MEDSMDiagnosisListID { get; set; }

        [Required]
        [StringLength(90)]
        [Display(Name = "DSM diagnosis")]
        public string Description { get; set; }

        public int MEDSMDiagnosisCategoryID { get; set; }

        [ForeignKey("MEDSMDiagnosisCategoryID")]
        public virtual MEDSMDiagnosisCategory MEDSMDiagnosisCategory { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<MEDSMDiagnosis> MEDSMDiagnosis { get; set; }
    }
}
