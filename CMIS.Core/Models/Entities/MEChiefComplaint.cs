using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("MEChiefComplaint")]
    public class MEChiefComplaint
    {
        [Key]
        public Guid MEChiefComplaintID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Chief complaints")]
        [DataType(DataType.MultilineText)]
        public string Complaint { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "History of chief complaints")]
        [DataType(DataType.MultilineText)]
        public string HistoryOfChiefComplaint { get; set; }

        [Display(Name = "Other systems review")]
        [DataType(DataType.MultilineText)]
        public string OtherSystemsReview { get; set; }

        [MEIfDiabetesNotSelected]
        public YesNo Diabetes { get; set; }

        [MEIfHypertensionNotSelected]
        public YesNo Hypertension { get; set; }

        [MEIfEpilepsyNotSelected]
        public YesNo Epilepsy { get; set; }

        [MEIfAllergiesNotSelected]
        public YesNo Allergies { get; set; }

        [Display(Name = "Drug type")]
        public DrugType DrugType { get; set; }

        public Guid ClientID { get; set; }

        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }

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

        //public virtual IQueryable<MEExamination> MEExamination { get; set; }
        public virtual IQueryable<MEClinicalDiagnosis> MEClinicalDiagnosis { get; set; }
        public virtual IQueryable<MEDSMDiagnosis> MEDSMDiagnosis { get; set; }
        public virtual IQueryable<MEAllergy> MEAllergy { get; set; }
        public virtual IQueryable<MENCD> MENCD { get; set; }
    }
}
