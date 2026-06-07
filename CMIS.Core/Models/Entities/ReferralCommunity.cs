using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("ReferralCommunity")]
    public class ReferralCommunity
    {
        [Key]
        public Guid ReferralCommunityID { get; set; }

        [Display(Name = "Referral type")]
        public ReferralTypes ReferralType { get; set; }

        [Display(Name = "From service point")]
        public FacilityServicePoints FromServicePoint { get; set; }

        [Required(ErrorMessage = "Required!")]
        [ReferralCommunityIfReferralDateIsFutureDate]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Display(Name = "Referral date")]
        [Column(TypeName = "smalldatetime")]
        public DateTime ReferredDate { get; set; }

        [Required(ErrorMessage = "Required!")]
        [ReferralCommunityIfExpectedDateIsOlderDate]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Display(Name = "Expected date")]
        [Column(TypeName = "smalldatetime")]
        public DateTime ExpectedDate { get; set; }

        [Display(Name = "Arrival date")]
        [Column(TypeName = "smalldatetime")]
        public DateTime? ArrivalDate { get; set; }

        [Display(Name = "Home visit")]
        public YesNo HomeVisit { get; set; }

        [Display(Name = "Follow-up calls")]
        public YesNo PhoneContact { get; set; }

        [Display(Name = "Send reminder")]
        public YesNo SendReminder { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Referred by")]
        [StringLength(30)]
        [DataType(DataType.Text)]
        public string ReferredBy { get; set; }

        [Required(ErrorMessage = "Required!")]
        public int CommunityID { get; set; }

        [ForeignKey("CommunityID")]
        public virtual Community Community { get; set; }

        [Required(ErrorMessage = "Required!")]
        public int TinkhundlaID { get; set; }

        [Required(ErrorMessage = "Required!")]
        public int ReferralReasonID { get; set; }

        [ForeignKey("ReferralReasonID")]
        public virtual ReferralReason ReferralReason { get; set; }

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
