using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("TBDR")]
    public class TBDR
    {
        [Key]
        public Guid TBDRID { get; set; }

        [DataType(DataType.MultilineText)]
        public string DiseaseSiteNote { get; set; }

        [Display(Name = "Number of days of days treatment directly observed")]
        public int TreatmentDirectlyObserved { get; set; }

        [Display(Name = "Number of days of days treatment not supervised")]
        public int TreatmentNotSupervised { get; set; }

        [Display(Name = "Number of days of days treatment not taken")]
        public int TreatmentNotTaken { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Patient registration group")]
        public int TBDRPatientRegistrationGroupID { get; set; }

        [ForeignKey("TBDRPatientRegistrationGroupID")]
        public virtual TBDRPatientRegistrationGroup TBDRPatientRegistrationGroup { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Patient category")]
        public int TBDRPatientCategoryID { get; set; }

        [ForeignKey("TBDRPatientCategoryID")]
        public virtual TBDRPatientCategory TBDRPatientCategory { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Regimen type")]
        public int TBDRRegimenTypeID { get; set; }

        [ForeignKey("TBDRRegimenTypeID")]
        public virtual TBDRRegimenType TBDRRegimenType { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Case definition")]
        public int TBCaseDefinitionID { get; set; }

        [ForeignKey("TBCaseDefinitionID")]
        public virtual TBCaseDefinition TBCaseDefinition { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Population sub group")]
        public int TBPopulationSubGroupID { get; set; }

        [ForeignKey("TBPopulationSubGroupID")]
        public virtual TBPopulationSubGroup TBPopulationSubGroup { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Disease site")]
        public int TBDiseaseSiteID { get; set; }

        [ForeignKey("TBDiseaseSiteID")]
        public virtual TBDiseaseSite TBDiseaseSite { get; set; }

        [Display(Name = "Culture Conversion")]
        public int TBDRCultureConversionID { get; set; }

        [ForeignKey("TBDRCultureConversionID")]
        public virtual TBDRCultureConversion TBDRCultureConversion { get; set; }

        [Display(Name = "Rx outcome id")]
        public int? TBRxOutcomeID { get; set; }

        [ForeignKey("TBRxOutcomeID")]
        public virtual TBRxOutcome TBRxOutcome { get; set; }

        public Guid ClientID { get; set; }

        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }

        public IQueryable<TBDRAdverseEventRecord> TBDRAdverseEventRecords { get; set; }

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
