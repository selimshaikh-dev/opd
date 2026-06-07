using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("LabRequest")]
    public class LabRequest
    {
        [Key]
        public Guid LabRequestID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(30)]
        [Display(Name = "Lab request number")]
        public string LabRequestNumber { get; set; }

        [LabIfRequestDateIsFutureDate]
        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Request date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        public DateTime RequestDate { get; set; }

        [LabIfSpecimenCollectionDateIsFutureDate]
        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Specimen collected date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        public DateTime SpecimenCollectedDate { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(47)]
        public string Requestor { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(10)]
        [Display(Name = "Time collected")]
        public string TimeCollected { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Facility service point")]
        public FacilityServicePoints FacilityServicePoint { get; set; }

        [Required(ErrorMessage = "Required!")]
        public int LabSpecimenID { get; set; }

        [ForeignKey("LabSpecimenID")]
        public virtual LabSpecimen LabSpecimen { get; set; }

        [Required(ErrorMessage = "Required!")]
        public int LabPriorityID { get; set; }

        [ForeignKey("LabPriorityID")]
        public virtual LabPriority LabPriority { get; set; }

        [Required(ErrorMessage = "Required!")]
        public int LabTestReasonID { get; set; }

        [ForeignKey("LabTestReasonID")]
        public virtual LabTestReason LabTestReason { get; set; }

        public Guid ClientID { get; set; }

        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }

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

        public virtual IQueryable<LabTestRequest> LabTestRequest { get; set; }
    }
}
