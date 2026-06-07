using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("MEExamination")]
    public class MEExamination
    {
        [Key]
        public Guid MEExaminationID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [DataType(DataType.MultilineText)]
        public string Findings { get; set; }

        [Required(ErrorMessage = "Required!")]
        public int MEExaminationListID { get; set; }

        [ForeignKey("MEExaminationListID")]
        public virtual MEExaminationList MEExaminationList { get; set; }

        public Guid MEChiefComplaintID { get; set; }

        [ForeignKey("MEChiefComplaintID")]
        public virtual MEChiefComplaint MEChiefComplaint { get; set; }

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
