using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("TBDRAdverseEventRecord")]
    public class TBDRAdverseEventRecord
    {
        [Key]
        public Guid TBDRAdverseEventRecordID { get; set; }

        [Display(Name = "Adverse event")]
        public int TBDRAdverseEventID { get; set; }

        [ForeignKey("TBDRAdverseEventID")]
        public virtual TBDRAdverseEvent TBDRAdverseEvent { get; set; }

        public int TBDRAdverseEventStatusID { get; set; }

        [ForeignKey("TBDRAdverseEventStatusID")]
        public virtual TBDRAdverseEventStatus TBDRAdverseEventStatus { get; set; }

        [TBDRADEIfOnsetDateIsFutureDate]
        [Display(Name = "Onset date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        public DateTime OnsetDate { get; set; }

        [Display(Name = "Severity")]
        public int TBDRSeverityID { get; set; }

        [ForeignKey("TBDRSeverityID")]
        public virtual TBDRSeverity TBDRSeverity { get; set; }

        [Display(Name = "Adverse Seriousness")]
        public int TBDRSeriousnessID { get; set; }

        [ForeignKey("TBDRSeriousnessID")]
        public virtual TBDRSeriousness TBDRSeriousness { get; set; }

        [Display(Name = "ADE Management")]
        public int TBDRADEManagementID { get; set; }

        [ForeignKey("TBDRADEManagementID")]
        public virtual TBDRADEManagement TBDRADEManagement { get; set; }

        [TBDRADEIfEndDateLessThanOnsetDate]
        [TBDRADEIfEndDateIsFutureDate]
        [Display(Name = "End date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Outcome")]
        public int? TBDRADEOutcomeID { get; set; }

        [ForeignKey("TBDRADEOutcomeID")]
        public virtual TBDRADEOutcome TBDRADEOutcome { get; set; }

        public Guid TBDRID { get; set; }

        [ForeignKey("TBDRID")]
        public virtual TBDR TBDR { get; set; }

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
