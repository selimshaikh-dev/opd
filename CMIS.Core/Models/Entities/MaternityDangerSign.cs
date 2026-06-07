using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("MaternityDangerSign")]
    public class MaternityDangerSign
    {
        [Key]
        public Guid MaternityDangerSignID { get; set; }

        public int? MotherDangerSignListID { get; set; }

        [ForeignKey("MotherDangerSignListID")]
        public virtual PNCDangerSignList PNCDangerSignList { get; set; }

        public int? ChildDangerSignListID { get; set; }

        [ForeignKey("ChildDangerSignListID")]
        public virtual PNCChildDangerSignList PNCChildDangerSignList { get; set; }

        public Guid MaternityID { get; set; }

        [ForeignKey("MaternityID")]
        public virtual Maternity Maternity { get; set; }

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
    }
}
