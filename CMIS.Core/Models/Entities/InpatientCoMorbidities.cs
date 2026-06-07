using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("InpatientCoMorbidities")]
    public class InpatientCoMorbidities
    {
        [Key]
        public Guid InpatientCoMobiditiesID { get; set; }

        public Guid InpatientAdmissionID { get; set; }

        [ForeignKey("InpatientAdmissionID")]
        public virtual InpatientAdmission InpatientAdmission { get; set; }

        public int InpatientCoMorbiditiesListID { get; set; }

        [ForeignKey("InpatientCoMorbiditiesListID")]
        public virtual InpatientCoMorbiditiesList InpatientCoMorbiditiesList { get; set; }

        [StringLength(10)]
        public string FacilityCode { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateCreated { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateModified { get; set; }

        public Guid? ModifiedBy { get; set; }

        public RowStatus? RowStatus { get; set; }

        public RowSyncStatus SyncStatus { get; set; }

        public Guid? VisitID { get; set; }
    }
}
