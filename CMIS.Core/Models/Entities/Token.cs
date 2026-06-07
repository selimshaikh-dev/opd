using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("Token")]
    public class Token
    {
        [Key]
        public Guid TokenID { get; set; }

        public int TokenNumber { get; set; }

        public DateTime DateGenerated { get; set; }

        public bool IsTokenServerd { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Facility service point")]
        public FacilityServicePoints FacilityServicePoint { get; set; }

        [StringLength(10)]
        public string FacilityCode { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateCreated { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateModified { get; set; }

        public Guid? ModifiedBy { get; set; }

        public RowStatus? RowStatus { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public Guid VisitID { get; set; }

        [ForeignKey("VisitID")]
        public virtual Visit Visit { get; set; }
    }
}
