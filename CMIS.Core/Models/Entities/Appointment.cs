using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("Appointment")]
    public class Appointment
    {
        [Key]
        public Guid AppointmentID { get; set; }

        [Required]
        [Display(Name = "Appointment date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime AppointmentDate { get; set; }

        [Display(Name = "Check in")]
        public bool CheckIn { get; set; }

        [Display(Name = "Date checked in")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime? DateCheckedIn { get; set; }

        [StringLength(300)]
        [DataType(DataType.MultilineText)]
        public string Note { get; set; }

        [Required]
        [AppointmentIfFacilityServicePointNotSelected]
        [Display(Name = "Facility service point")]
        public FacilityServicePoints FacilityServicePoint { get; set; }

        public Guid ClientID { get; set; }

        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }

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
