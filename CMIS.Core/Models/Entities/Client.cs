using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public Guid ClientID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(35)]
        [Display(Name = "Patient ID")]
        [DataType(DataType.Text)]
        public string PatientID { get; set; }

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

        [Display(Name = "Middle name")]
        [StringLength(30)]
        [DataType(DataType.Text)]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(30)]
        [Display(Name = "Last name")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required!")]
        [ClientIfDOBIsFutureDate]
        [Display(Name = "Date of birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "Smalldatetime")]
        public DateTime DOB { get; set; }

        [IfSexNotSelectedForClient]
        [Display(Name = "Sex")]
        public Sex Sex { get; set; }

        [IfMaritalStatusNotSelectedForClient]
        [Display(Name = "Marital status")]
        public MaritalStatus MaritalStatus { get; set; }

        [IfNationalityNotSelectedForClient]
        [Display(Name = "Country of origin")]
        public Country Nationality { get; set; }

        [Display(Name = "Cient is handicaped.")]
        public bool? IsClientDisabled { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Residential address")]
        [StringLength(250)]
        [DataType(DataType.MultilineText)]
        public string ResidentialAddress { get; set; }

        [Display(Name = "Postal address")]
        [StringLength(250)]
        [DataType(DataType.MultilineText)]
        public string PostalAddress { get; set; }

        [StringLength(3)]
        [Display(Name = "Country code")]
        [DataType(DataType.Text)]
        public string CellphoneCountryCode { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "Cellphone should be atleast 8 digits")]
        [Display(Name = "Cellphone")]
        [DataType(DataType.Text)]
        public string Cellphone { get; set; }

        [StringLength(3)]
        [Display(Name = "Country code")]
        [DataType(DataType.Text)]
        public string LandPhoneCountryCode { get; set; }

        [StringLength(15, MinimumLength = 8, ErrorMessage = "Landphone should be atleast 8 digits")]
        [Display(Name = "Land phone")]
        [DataType(DataType.Text)]
        public string LandPhone { get; set; }

        [StringLength(60)]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(38)]
        [Display(Name = "Patient ID")]
        [DataType(DataType.Text)]
        public string RootPatientID { get; set; }

        public Guid? MothersID { get; set; }

        [ClientIfDeceasedDateIsFutureDate]
        [ClientIfDeceasedDateLessThanDOB]
        [Display(Name = "Deceased Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeceasedDate { get; set; }

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

        public int ChiefdomID { get; set; }

        [ForeignKey("ChiefdomID")]
        public virtual Chiefdom Chiefdom { get; set; }

        //NONE CLINICAL:
        public virtual IQueryable<Relative> Relatives { get; set; }
        public virtual IQueryable<Appointment> Appointments { get; set; }
        public virtual IQueryable<Visit> Visits { get; set; }

        //OUT PATIENT:
        public virtual IQueryable<Vital> Vitals { get; set; }
        public virtual IQueryable<TBScreening> TBScreenings { get; set; }
        public virtual IQueryable<HTS> HTS { get; set; }
        public virtual IQueryable<TBDS> TBDS { get; set; }
        public virtual IQueryable<TBDR> TBDR { get; set; }
        public virtual IQueryable<ANC> ANC { get; set; }
        public virtual IQueryable<PNC> PNC { get; set; }
        public virtual IQueryable<MC> MC { get; set; }
        public virtual IQueryable<ChildWelfare> ChildWelfares { get; set; }
        public virtual IQueryable<CervicalCancer> CervicalCancers { get; set; }
        public virtual IQueryable<FamilyPlanning> FamilyPlanning { get; set; }
        public virtual IQueryable<Maternity> Maternity { get; set; }
        public virtual IQueryable<InpatientAdmission> InpatientAdmission { get; set; }
        public virtual IQueryable<PalliativeCare> PalliativeCare { get; set; }
        public virtual IQueryable<ReferralCommunity> ReferralCommunity { get; set; }
        public virtual IQueryable<ReferralFacility> ReferralFacility { get; set; }
        public virtual IQueryable<ART> ART { get; set; }
        public virtual IQueryable<Prescription> Prescription { get; set; }
        public virtual IQueryable<IndexClient> IndexClient { get; set; }
        public virtual IQueryable<Immunization> ChildWelfareImmunization { get; set; }
        public virtual IQueryable<ARTAdherence> ARTAdherence { get; set; }
    }
}