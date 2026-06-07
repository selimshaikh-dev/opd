using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("PNC")]
    public class PNC
    {
        [Key]
        public Guid PNCID { get; set; }

        [PNCIfVisitTypeIsNotSelected]
        public VisitType VisitType { get; set; }

        [Display(Name = "Place of delivery")]
        public PNCPlaceOfDelivery PlaceOfDelivery { get; set; }

        [PNCIfDateOfDeliveryIsFutureDate]
        [PNCIfPlaceOfDeliveryHomeIsSelected]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Display(Name = "Date of delivery")]
        [Column(TypeName = "smalldatetime")]
        public DateTime? DateOfDelivery { get; set; }

        [Required(ErrorMessage = "Required!")]
        public int PNCLochiaID { get; set; }

        [ForeignKey("PNCLochiaID")]
        public virtual PNCLochia PNCLochia { get; set; }

        [Required(ErrorMessage = "Required!")]
        public int FamilyPlanningMethodID { get; set; }

        [ForeignKey("FamilyPlanningMethodID")]
        public virtual FPMethod FamilyPlanningMethod { get; set; }

        [Required(ErrorMessage = "Required!")]
        public int PNCBreastConditionID { get; set; }

        [ForeignKey("PNCBreastConditionID")]
        public virtual PNCBreastCondition PNCBreastCondition { get; set; }

        [Required(ErrorMessage = "Required!")]
        public int PNCInvolutionID { get; set; }

        [ForeignKey("PNCInvolutionID")]
        public virtual PNCInvolution PNCInvolution { get; set; }

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

        public virtual IQueryable<PNCDangerSign> PNCDangerSign { get; set; }
    }
}
