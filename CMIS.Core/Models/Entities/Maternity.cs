using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("Maternity")]
    public class Maternity
    {
        [Key]
        public Guid MaternityID { get; set; }

        [MaternityIfAdmissionDateIsFutureDate]
        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Date of admission")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        public DateTime DateOfAdmission { get; set; }

        [Display(Name = "Chief complaint")]
        [StringLength(200)]
        [DataType(DataType.MultilineText)]
        public string ChiefComplaint { get; set; }

        [MaternityIfDeliveryDateIsFutureDate]
        [MaternityDeliveryDateLessThanAdmissionDate]
        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Delivery date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        public DateTime DeliveryDate { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Delivery time")]
        [StringLength(5)]
        public string DeliveryTime { get; set; }

        [Display(Name = "Delivery mode")]
        public int MaternityDeliveryModeID { get; set; }

        [ForeignKey("MaternityDeliveryModeID")]
        public virtual MaternityDeliveryMode MaternityDeliveryMode { get; set; }

        [Display(Name = "Pregnancy outcome")]
        public int MaternityPregnancyOutcomeID { get; set; }

        [ForeignKey("MaternityPregnancyOutcomeID")]
        public virtual MaternityPregnancyOutcome MaternityPregnancyOutcome { get; set; }

        [Display(Name = "Weight of baby (kg)")]
        [Range(0.5, 15)]
        public decimal WeightOfBaby { get; set; }

        [MaternityIfSexOfBabyNotSelected]
        [Display(Name = "Sex of baby")]
        public SexOfBaby SexOfBaby { get; set; }

        public int FeedingOptionID { get; set; }

        [ForeignKey("FeedingOptionID")]
        public virtual FeedingOption FeedingOption { get; set; }

        [Display(Name = "Mother's condition")]
        [StringLength(200)]
        [DataType(DataType.MultilineText)]
        public string ConditionOfMother { get; set; }

        [Display(Name = "Baby's condition")]
        [StringLength(200)]
        [DataType(DataType.MultilineText)]
        public string ConditionOfBaby { get; set; }

        [Display(Name = "Apgar Score")]
        [Range(0, 10)]
        public int ApgarScore { get; set; }

        [Display(Name = "Parity")]
        [Range(0, 20)]
        public int Parity { get; set; }

        [Display(Name = "Arrival time")]
        [StringLength(5)]
        public string ArrivalTime { get; set; }

        [Display(Name = "Home Delivery")]
        public bool HomeDelivery { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Delivered by")]
        [StringLength(47)]
        public string DeliveredBy { get; set; }

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

        public virtual IQueryable<MaternityDangerSign> MaternityDangerSign { get; set; }
    }
}
