using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("FamilyPlanning")]
    public class FamilyPlanning
    {
        [Key]
        public Guid FamilyPlanningID { get; set; }

        [FPStatusNotSelected]
        [Display(Name = "FP Status")]
        public FPStatus FPStatus { get; set; }

        [FamilyPlanningIfPapSmearResultNotSelected]
        [Display(Name = "PAP smear result")]
        public PAPSmearResult PAPSmearResult { get; set; }

        [FamilyPlanningIfViaResultNotSelected]
        [Display(Name = "VIA result")]
        public VIAResult VIAResult { get; set; }

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
