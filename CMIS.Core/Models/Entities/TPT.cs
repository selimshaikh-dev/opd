using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("TPT")]
    public class TPT
    {
        [Key]
        public Guid TPTID { get; set; }

        [Display(Name = "Started TPT?")]
        public YesNo HasStartedTPT { get; set; }

        [Display(Name = "TPT start date")]
        [Column(TypeName = "smalldatetime")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime? TPTStartDate { get; set; }

        [Display(Name = "TPT stop date")]
        [Column(TypeName = "smalldatetime")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime? TPTStopDate { get; set; }

        public Guid ClientID { get; set; }

        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }

        public int? TPTNotStartedReasonID { get; set; }

        [ForeignKey("TPTNotStartedReasonID")]
        public virtual TPTNotStartedReason TPTNotStartedReason { get; set; }

        public int? TPTOutcomeID { get; set; }

        [ForeignKey("TPTOutcomeID")]
        public virtual TPTOutcome TPTOutcome { get; set; }

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
