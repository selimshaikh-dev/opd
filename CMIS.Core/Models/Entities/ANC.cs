using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("ANC")]
    public class ANC
    {
        [Key]
        public Guid ANCID { get; set; }

        [Display(Name = "Gravida")]
        public int? Gravida { get; set; }

        [Display(Name = "Para")]
        public int? Para { get; set; }

        [Display(Name = "Forceps or vacuum extraction")]
        public YesNo ForcepsOrVacuumExtraction { get; set; }

        [Display(Name = "APH / PPH")]
        public YesNo APHOrPPH { get; set; }

        [Display(Name = "Manual removal of placenta")]
        public YesNo ManualRemovalOfPlacenta { get; set; }

        [Display(Name = "Caesarean Section")]
        public YesNo CesareanSection { get; set; }

        [IfYesNoNotSelected]
        [Display(Name = "First ANC")]
        public YesNo IsFirstANC { get; set; }

        [Required(ErrorMessage = "Required!")]
        [ANCIfLMPIsFutureDate]
        [Display(Name = "Last known menstrual period")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        public DateTime LastKnownMenstrualPeriod { get; set; }

        public bool Estimated { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Gestation (Week)")]
        public int Gestation { get; set; }

        [IfYesNoNotSelected]
        [Display(Name = "Gestation by scan")]
        public YesNo GestationByScan { get; set; }

        public bool Bleeding { get; set; }

        [Display(Name = "Fetal movement")]
        public bool FetalMovement { get; set; }

        [ANCEDDDateLessThanLMPDate]
        [Display(Name = "Expected delivery date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime ExpectedDeliveryDate { get; set; }

        [IfYesNoNotSelected]
        [Display(Name = "Expected delivery date by scan")]
        public YesNo ExpectedDeliveryDateByScan { get; set; }

        public decimal HOF { get; set; }

        public bool Oedema { get; set; }

        [Display(Name = "FHR")]
        [ANCIFFHRStatusNormalIsSelected]
        public int? ANCFHR { get; set; }

        public int? ANCProteinID { get; set; }

        [ForeignKey("ANCProteinID")]
        public virtual ANCProtein ANCProtein { get; set; }

        public int? ANCPPID { get; set; }

        [ForeignKey("ANCPPID")]
        public virtual ANCPP ANCPP { get; set; }

        [ANCIfANCHFRStatusIsNotSelected]
        public int? ANCFHRID { get; set; }

        [ForeignKey("ANCFHRID")]
        public virtual ANCFHR ANCFHRStatus { get; set; }

        [ANCIfStopDateIsSelected]
        public int? ANCStopReasonID { get; set; }

        [ForeignKey("ANCStopReasonID")]
        public virtual ANCStopReason ANCStopReason { get; set; }

        [Display(Name = "Stop Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        public DateTime? StopDate { get; set; }

        public virtual IQueryable<ANCClientVaginalAssessment> ANCClientVaginalAssessment { get; set; }

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