using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("PNCDangerSign")]
    public class PNCDangerSign
    {
        [Key]
        public Guid PNCDangerSignID { get; set; }

        public Guid PNCID { get; set; }

        [ForeignKey("PNCID")]
        public virtual PNC PNC { get; set; }

        public int PNCDangerSignListID { get; set; }

        [ForeignKey("PNCDangerSignListID")]
        public virtual PNCDangerSignList PNCDangerSignList { get; set; }

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
