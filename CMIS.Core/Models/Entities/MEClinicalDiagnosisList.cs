using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("MEClinicalDiagnosisList")]
    public class MEClinicalDiagnosisList
    {
        [Key]
        public int MEClinicalDiagnosisListID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(20)]
        [Display(Name = "ICD code")]
        [DataType(DataType.Text)]
        public string ICDCode { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(250)]
        [Display(Name = "ICD diagnosis")]
        [DataType(DataType.Text)]
        public string ICDDiagnosis { get; set; }

        [StringLength(250)]
        [Display(Name = "Common diagnosis")]
        [DataType(DataType.Text)]
        public string CommonDiagnosis { get; set; }

        public int MEClinicalDiagnosisCategoryID { get; set; }

        [ForeignKey("MEClinicalDiagnosisCategoryID")]
        public virtual MEClinicalDiagnosisCategory MEClinicalDiagnosisCategory { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<MEClinicalDiagnosis> MEClinicalDiagnosis { get; set; }
    }
}