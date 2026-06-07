using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("PNCChildDangerSign")]
    public class PNCChildDangerSign
    {
        [Key]
        public Guid PNCChildDangerSignID { get; set; }

        public Guid PNCChildID { get; set; }

        [ForeignKey("PNCChildID")]
        public virtual PNCChild PNCChild { get; set; }

        public int PNCChildDangerSignListID { get; set; }

        [ForeignKey("PNCChildDangerSignListID")]
        public virtual PNCChildDangerSignList PNCChildDangerSignList { get; set; }

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
