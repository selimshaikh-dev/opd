using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("ChildWelfare")]
    public class ChildWelfare
    {
        [Key]
        public Guid ChildWelfareID { get; set; }

        [ChildWelfareIfVisitTypeIsNotSelected]
        [Display(Name = "Visit Type")]
        public VisitType VisitType { get; set; }

        [Display(Name = "Received NVP (12Weeks)")]
        public bool ReceivedNVPAt12Weeks { get; set; }

        [Display(Name = "Infant exposure (TB)")]
        public bool InfantExposer { get; set; }

        [Display(Name = "Infant exposure (HIV)")]
        public bool InfantExposureHIV { get; set; }

        [Display(Name = "EIMC discussed")]
        public bool EIMCDiscussed { get; set; }

        [Display(Name = "BCG scar")]
        public bool BCGScar { get; set; }

        [Display(Name = "Feeding options")]
        public int FeedingOptionID { get; set; }

        [ForeignKey("FeedingOptionID")]
        public virtual FeedingOption FeedingOption { get; set; }

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