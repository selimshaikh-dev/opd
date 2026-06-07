using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("Medication")]
    public class Medication
    {
        [Key]
        public Guid MedicationID { get; set; }

        [Required(ErrorMessage = "Required!")]
        public double Quantity { get; set; }

        [Display(Name = "Duration (days)")]
        public int? Duration { get; set; }

        public double Calculation { get; set; }

        [Display(Name = "Dispense")]
        public double DispensedQuantity { get; set; }

        [Display(Name = "Amount remaining")]
        public int? AmountRemaining { get; set; }

        [StringLength(600)]
        [DataType(DataType.Text)]
        public string Notes { get; set; }

        public Guid PrescriptionID { get; set; }

        [ForeignKey("PrescriptionID")]
        public virtual Prescription Prescription { get; set; }

        [Display(Name = "Description")]
        public int DrugDescriptionID { get; set; }

        [ForeignKey("DrugDescriptionID")]
        public virtual DrugDescription DrugDescription { get; set; }

        //[Display(Name = "Form")]
        //public int DrugFormID { get; set; }

        //[ForeignKey("DrugFormID")]
        //public virtual DrugForm DrugForm { get; set; }

        [Display(Name = "Interval")]
        public int? DrugIntervalID { get; set; }

        [ForeignKey("DrugIntervalID")]
        public virtual DrugInterval DrugInterval { get; set; }

        [Display(Name = "Direction")]
        public int? DrugDirectionID { get; set; }

        [ForeignKey("DrugDirectionID")]
        public virtual DrugDirection DrugDirection { get; set; }

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