using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("PNCChild")]
    public class PNCChild
    {
        [Key]
        public Guid PNCChildID { get; set; }

        [Display(Name = "Given iNVP?")]
        public YesNo GivenINVP { get; set; }

        [Display(Name = "Early infant MC discussed?")]
        public YesNo EIMCDiscussed { get; set; }

        [Required(ErrorMessage = "Required!")]
        public int PNCChildConditionOfUmbilicalCordID { get; set; }

        [ForeignKey("PNCChildConditionOfUmbilicalCordID")]
        public virtual PNCChildConditionOfUmbilicalCord PNCChildConditionOfUmbilicalCord { get; set; }

        [Required(ErrorMessage = "Required!")]
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

        public virtual IQueryable<PNCChildDangerSign> PNCChildDangerSign { get; set; }
    }
}
