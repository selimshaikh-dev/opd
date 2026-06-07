using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("Prescription")]
    public class Prescription
    {
        [Key]
        public Guid PrescriptionID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        [Display(Name = "Prescription date")]
        public DateTime PrescriptionDate { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(47)]
        public string Prescriber { get; set; }

        [Display(Name = "General advice")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        [StringLength(47)]
        public string Dispenser { get; set; }

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

        public virtual IQueryable<Medication> Medication { get; set; }
    }
}