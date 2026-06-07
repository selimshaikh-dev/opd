using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public Guid UserID { get; set; }

        [Required(ErrorMessage = "Required!")]
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

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Date of birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "Smalldatetime")]
        public DateTime DOB { get; set; }

        [IfSexNotSelectedForUser]
        [Display(Name = "Sex")]
        [DataType(DataType.Text)]
        public Sex Sex { get; set; }

        [IfNationalityNotSelectedForUser]
        [Display(Name = "Country of origin")]
        [DataType(DataType.Text)]
        public Country Nationality { get; set; }

        [IfNoEmploymentNumberForUser]
        [StringLength(20)]
        [Display(Name = "Employment number")]
        [DataType(DataType.Text)]
        public string EmploymentNumber { get; set; }

        [Display(Name = "I don't have employment number.")]
        public bool NoEmploymentNumber { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(13)]
        [Display(Name = "Cell number")]
        [DataType(DataType.Text)]
        public string CellPhone { get; set; }

        [StringLength(13)]
        [Display(Name = "Land phone")]
        [DataType(DataType.Text)]
        public string LandPhone { get; set; }

        [StringLength(60)]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(250)]
        [Display(Name = "Contact address")]
        [DataType(DataType.MultilineText)]
        public string ContactAddress { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(30)]
        [Display(Name = "Username")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Required!")]
        [MinLength(5, ErrorMessage = "Password must have atleast 5 characters!")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Required!")]
        [MinLength(5, ErrorMessage = "Password must have atleast 5 characters!")]
        [Compare("Password", ErrorMessage = "Confirmed password does not match!")]
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public UserType UserType { get; set; }

        [Display(Name = "Designation")]
        public int DesignationID { get; set; }

        [ForeignKey("DesignationID")]
        public virtual Designation Designation { get; set; }

        [NotMapped]
        public string LoginFacilityCode { get; set; }

        [NotMapped]
        public String FacilityName { get; set; }

        [StringLength(10)]
        public string FacilityCode { get; set; }

        [Display(Name = "Health facility")]
        public int FacilityID { get; set; }

        [ForeignKey("FacilityID")]
        public virtual Facility Facility { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateCreated { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateModified { get; set; }

        public Guid? ModifiedBy { get; set; }

        public RowStatus? AccountStatus { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<UserAccess> UserAccess { get; set; }
    }
}