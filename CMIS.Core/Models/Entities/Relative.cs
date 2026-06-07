using CMIS.Core.Constants;
using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("Relative")]
    public class Relative
    {
        [Key]
        public Guid RelativeID { get; set; }

        [StringLength(13)]
        [Display(Name = "PIN")]
        [DataType(DataType.Text)]
        public string PIN { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(30)]
        [Display(Name = "First name")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [StringLength(30)]
        [Display(Name = "Middle name")]
        [DataType(DataType.Text)]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(30)]
        [Display(Name = "Last name")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Display(Name = "Date of birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "Smalldatetime")]
        public DateTime? DOB { get; set; }

        [IfSexNotSelectedForRelative]
        [Display(Name = "Sex")]
        public Sex Sex { get; set; }

        [Display(Name = "Marital status")]
        public MaritalStatus MaritalStatus { get; set; }

        [IfNationalityNotSelectedForRelative]
        [Display(Name = "Country of origin")]
        public Enumerators.Country Nationality { get; set; }

        [Display(Name = "Relationship type")]
        public int RelativeRelationshipTypeID { get; set; }

        [ForeignKey("RelativeRelationshipTypeID")]
        public virtual RelativeRelationshipType RelativeRelationshipType { get; set; }

        [StringLength(3)]
        [Display(Name = "Country code")]
        [DataType(DataType.Text)]
        public string CellphoneCountryCode { get; set; }

        [StringLength(15)]
        [Display(Name = "Cellphone")]
        [DataType(DataType.Text)]
        public string Cellphone { get; set; }

        [StringLength(3)]
        [Display(Name = "Country code")]
        [DataType(DataType.Text)]
        public string LandPhoneCountryCode { get; set; }

        [StringLength(15)]
        [Display(Name = "Land phone")]
        [DataType(DataType.Text)]
        public string LandPhone { get; set; }

        [StringLength(60)]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "This relative is treatment supporter.")]
        public bool IsTreatmentSupporter { get; set; }

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
