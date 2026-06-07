using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("MEDSMDiagnosis")]
    public class MEDSMDiagnosis
    {
        [Key]
        public Guid MEDSMDiagnosisID { get; set; }

        [Required(ErrorMessage = "Required!")]
        public int MEDSMDiagnosisListID { get; set; }

        [ForeignKey("MEDSMDiagnosisListID")]
        public virtual MEDSMDiagnosisList MEDSMDiagnosisList { get; set; }

        public Guid MEChiefComplaintID { get; set; }

        [ForeignKey("MEChiefComplaintID")]
        public virtual MEChiefComplaint MEChiefComplaint { get; set; }

        [StringLength(10)]
        public string FacilityCode { get; set; }

        public Guid? VisitID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateCreated { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateModified { get; set; }

        public Guid? ModifiedBy { get; set; }

        public RowStatus? RowStatus { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }
    }
}