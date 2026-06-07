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
    [Table("MEClinicalDiagnosisCategory")]
    public class MEClinicalDiagnosisCategory
    {
        [Key]
        public int MEClinicalDiagnosisCategoryID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Diagnosis category")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<MEClinicalDiagnosisList> MEClinicalDiagnosisList { get; set; }
    }
}
