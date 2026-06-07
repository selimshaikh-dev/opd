using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("Vital")]
    public class Vital
    {
        [Key]
        public Guid VitalID { get; set; }

        [Display(Name = "Functional Status")]
        public FunctionalStatus FunctionalStatus { get; set; }

        [VitalIfClientIsABaby]
        [VitalsIfWeightIsEmpty]
        [Range(2, 200, ErrorMessage = "Weight should be between 2kg and 200kg")]
        public decimal? Weight { get; set; }

        [VitalsIfHeightIsEmpty]
        [Range(10, 250, ErrorMessage = "Height should be between 10cm and 250cm")]
        public decimal? Height { get; set; }

        [Range(20, 60, ErrorMessage = "Temperature should be between 20 and 60 degrees celsius")]
        public decimal? Temperature { get; set; }

        [Range(5, 60, ErrorMessage = "MUAC should be between 5cm and 60cm")]
        public decimal? MUAC { get; set; }

        [Display(Name = "Systolic")]
        [Range(50, 350, ErrorMessage = "Systolic should be between 50mmHg and 350mmHg")]
        public short? BPSystolic { get; set; }

        [Display(Name = "Diastolic")]
        [Range(30, 150, ErrorMessage = "Diastolic should be between 40mmHg and 150mmHg")]
        public short? BPDiastolic { get; set; }

        [Display(Name = "Respiratory rate")]
        [Range(5, 300, ErrorMessage = "Respiratory rate should be between 5 and 300 breaths per minute")]
        public short? RespiratoryRate { get; set; }

        [Range(20, 400, ErrorMessage = "Pulse should be between 20bpm and 400bpm")]
        public short? Pulse { get; set; }

        [Display(Name = "Oxygen saturation")]
        [Range(50, 100, ErrorMessage = "Oxygen saturation should be between 50% and 100%")]
        public short? OxygenSaturation { get; set; }

        public decimal? BMI { get; set; }

        [Display(Name = "Nutritional status")]
        [StringLength(30)]
        public string NutritionalStatus { get; set; }

        [Display(Name = "Age for height")]
        [StringLength(30)]
        public string AgeForHeight { get; set; }

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
    }
}
