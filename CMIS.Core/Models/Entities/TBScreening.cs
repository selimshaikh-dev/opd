using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("TBScreening")]
    public class TBScreening
    {
        [Key]
        public Guid TBScreeningID { get; set; }

        [Display(Name = "Client coughing?")]
        [IfYesNoNotSelected]
        public YesNo IsClientCoughing { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Cough duration")]
        public int CoughDuration { get; set; }

        public bool Fever { get; set; }

        [Display(Name = "Night sweats")]
        public bool NightSweats { get; set; }

        [Display(Name = "Weight Loss")]
        public bool WeightLoss { get; set; }

        [Display(Name = "Chest pain")]
        public bool ChestPain { get; set; }

        [Display(Name = "TB contact")]
        public YesNo TBContact { get; set; }

        [IfYesNoNotSelected]
        [Display(Name = "Eligible for TPT?")]
        public YesNo IsEligibleForTPT { get; set; }

        [Display(Name = "Screening result")]
        public TBScreeningResults ScreeningResult { get; set; }

        [Display(Name = "Sputum ordered")]
        public YesNo SputumCollected { get; set; }

        public YesNo Referred { get; set; }

        public Guid ClientID { get; set; }

        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }

        [Display(Name = "Reason not eligible")]
        public int? TBScreeningTPTReasonID { get; set; }

        [ForeignKey("TBScreeningTPTReasonID")]
        public virtual TBScreeningTPTReason TBScreeningTPTReason { get; set; }

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
