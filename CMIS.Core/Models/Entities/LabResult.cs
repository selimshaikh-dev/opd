using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("LabResult")]
    public class LabResult
    {
        [Key]
        public Guid LabResultID { get; set; }

        [LabIfResultStatusIsDetectable]
        public string Result { get; set; }

        [Display(Name = "Test Parameter")]
        public int? LabTestParameterID { get; set; }

        [Display(Name = "Date results received")]
        [LabIfDateResultReceivedIsFutureDate]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        public DateTime DateResultReceived { get; set; }

        [Display(Name = "Date results received by client")]
        [LabIfDateResultsReceivedByClientIsFutureDate]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        public DateTime? DateResultReceivedByClient { get; set; }

        [Display(Name = "Result status")]
        public int LabResultStatusID { get; set; }

        [ForeignKey("LabResultStatusID")]
        public virtual LabResultStatus LabResultStatus { get; set; }

        public Guid LabTestRequestID { get; set; }

        [ForeignKey("LabTestRequestID")]
        public virtual LabTestRequest LabTestRequest { get; set; }

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