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
    [Table("MCPhysicalExaminationList")]
    public class MCPhysicalExaminationList
    {
        public Guid MCPhysicalExaminationListID { get; set; }

        public int MCPhysicalExaminationID { get; set; }

        [ForeignKey("MCPhysicalExaminationID")]
        public virtual MCPhysicalExamination MCPhysicalExamination { get; set; }

        public Guid MCID { get; set; }

        [ForeignKey("MCID")]
        public virtual MC MC { get; set; }

        [StringLength(10)]
        public string FacilityCode { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateCreated { get; set; }

        public Guid? CreatedBy { get; set; }

        public RowStatus? RowStatus { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }
    }
}
