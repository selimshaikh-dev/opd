using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("LabTestRequest")]
    public class LabTestRequest
    {
        [Key]
        public Guid LabTestRequestID { get; set; }

        public Guid LabRequestID { get; set; }

        [ForeignKey("LabRequestID")]
        public virtual LabRequest LabRequest { get; set; }

        public int LabTestDescriptionID { get; set; }

        [ForeignKey("LabTestDescriptionID")]
        public virtual LabTestDescription LabTestDescription { get; set; }

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

        public virtual IQueryable<LabResult> LabResults { get; set; }
    }
}