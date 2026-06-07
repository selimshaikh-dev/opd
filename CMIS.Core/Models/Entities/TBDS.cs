using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("TBDS")]
    public class TBDS
    {
        [Key]
        public Guid TBDSID { get; set; }

        [StringLength(200)]
        [Display(Name = "Disease sight note/desc.")]
        [DataType(DataType.MultilineText)]
        public string DiseaseSightNote { get; set; }

        [Display(Name = "Number of days treatment directly observed")]
        public int? DirectlyObservedDays { get; set; }

        [Display(Name = "Number of days treatment not supervised")]
        public int? NotSupervisedDays { get; set; }

        [Display(Name = "Number of days treatment not taken")]
        public int? NotTakenDays { get; set; }

        [Display(Name = "Patient category")]
        [Required(ErrorMessage = "Required!")]
        public int TBDSPatientCategoryID { get; set; }

        [ForeignKey("TBDSPatientCategoryID")]
        public virtual TBDSPatientCategory TBDSPatientCategory { get; set; }

        [Display(Name = "Case definition")]
        [Required(ErrorMessage = "Required!")]
        public int TBCaseDefinitionID { get; set; }

        [ForeignKey("TBCaseDefinitionID")]
        public virtual TBCaseDefinition TBCaseDefinition { get; set; }

        [Display(Name = "Disease site")]
        [Required(ErrorMessage = "Required!")]
        public int TBDiseaseSiteID { get; set; }

        [ForeignKey("TBDiseaseSiteID")]
        public virtual TBDiseaseSite TBDiseaseSite { get; set; }

        [Display(Name = "Patient registration group")]
        [Required(ErrorMessage = "Required!")]
        public int TBPatientRegistrationGroupID { get; set; }

        [ForeignKey("TBPatientRegistrationGroupID")]
        public virtual TBPatientRegistrationGroup TBPatientRegistrationGroup { get; set; }

        [Display(Name = "Population sub group")]
        [Required(ErrorMessage = "Required!")]
        public int TBPopulationSubGroupID { get; set; }

        [ForeignKey("TBPopulationSubGroupID")]
        public virtual TBPopulationSubGroup TBPopulationSubGroup { get; set; }

        [Display(Name = "Smear conversion status (2/3 months)")]
        public int TBDSSmearConversionStatusID { get; set; }

        [ForeignKey("TBDSSmearConversionStatusID")]
        public virtual TBDSSmearConversionStatus TBDSSmearConversionStatus { get; set; }

        [IfYesNoNotSelected]
        [Display(Name = "Currently on treatment")]
        public YesNo OnTreatment { get; set; }

        [Display(Name = "Interim outcome")]
        public int? TBDSInterimOutcomeID { get; set; }

        [ForeignKey("TBDSInterimOutcomeID")]
        public virtual TBDSInterimOutcome TBDSInterimOutcome { get; set; }

        [Display(Name = "Rx outcome")]
        public int? TBRxOutcomeID { get; set; }

        [ForeignKey("TBRxOutcomeID")]
        public virtual TBRxOutcome TBRxOutcome { get; set; }

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
    }
}
