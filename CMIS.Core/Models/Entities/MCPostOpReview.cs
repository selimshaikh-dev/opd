using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("MCPostOpReview")]
    public class MCPostOpReview
    {
        [Key]
        public Guid MCPostOpReviewID { get; set; }

        [MCIfPostOpReviewDateIsFutureDate]
        [Display(Name = "Review date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime ReviewDate { get; set; }

        [MCIfPostOpReviewAdverseEventIsSelected]
        [Display(Name = "Severity grade")]
        public SeverityGrade SeverityGrade { get; set; }

        [StringLength(600)]
        [Display(Name = "Clinical notes")]
        [DataType(DataType.MultilineText)]
        public string Note { get; set; }

        public int? MCAdverseEventID { get; set; }

        [ForeignKey("MCAdverseEventID")]
        public virtual MCAdverseEvent MCAdverseEvent { get; set; }

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
