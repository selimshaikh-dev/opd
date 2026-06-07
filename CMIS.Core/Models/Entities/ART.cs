using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("ART")]
    public class ART
    {
        [Key]
        public Guid ARTID { get; set; }

        [Display(Name = "Risk assessment done?")]
        public YesNo IsRiskAssessmentDone { get; set; }

        [Display(Name = "Client initiated on ART?")]
        public YesNo IsClientInitiatedOnART { get; set; }

        [StringLength(300)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Reason (not initiated)")]
        public string ReasonClientNotInitiated { get; set; }

        [Display(Name = "ART start date")]
        [Column(TypeName = "smalldatetime")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime? ARTStartDate { get; set; }

        [Display(Name = "ART stop date")]
        [Column(TypeName = "smalldatetime")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime? ARTStopDate { get; set; }

        public Guid ClientID { get; set; }

        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }

        [Required(ErrorMessage = "Required!")]
        public int ARTFunctionalStatusID { get; set; }

        [ForeignKey("ARTFunctionalStatusID")]
        public virtual ARTFunctionalStatus ARTFunctionalStatus { get; set; }

        public int? ARTRegimenID { get; set; }

        [ForeignKey("ARTRegimenID")]
        public virtual ARTRegimen ARTRegimen { get; set; }

        public int? ARTRegimenChangeReasonID { get; set; }

        [ForeignKey("ARTRegimenChangeReasonID")]
        public virtual ARTRegimenChangeReason ARTRegimenChangeReason { get; set; }

        public int? ARTCareModelID { get; set; }

        [ForeignKey("ARTCareModelID")]
        public virtual ARTCareModel ARTCareModel { get; set; }

        public int? ARTCareModelChangeReasonID { get; set; }

        [ForeignKey("ARTCareModelChangeReasonID")]
        public virtual ARTCareModelChangeReason ARTCareModelChangeReason { get; set; }

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

        public virtual IQueryable<ARTOI> ARTOI { get; set; }
    }
}
