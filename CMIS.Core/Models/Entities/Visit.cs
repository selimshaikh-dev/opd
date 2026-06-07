using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("Visit")]
    public class Visit
    {
        [Key]
        public Guid VisitID { get; set; }

        [Required]
        [StringLength(10)]
        public string FacilityCode { get; set; }

        public DateTime VisitDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        [Display(Name = "Visit date")]
        public DateTime? DateCreated { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateModified { get; set; }

        public Guid? ModifieBy { get; set; }

        public RowStatus? RowStatus { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public Guid ClientID { get; set; }

        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }
    }
}
