using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    public class HTSInvitee
    {
        public Guid HTSInviteeID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(30)]
        [Display(Name = "First name")]
        [DataType(DataType.Text)] public string FirstName { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(30)]
        [Display(Name = "Last name")]
        [DataType(DataType.Text)] public string LastName { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "Cellphone should be between 8 and 13 digits")]
        [Display(Name = "Cellphone")]
        [DataType(DataType.Text)]
        public string Cellphone { get; set; }

        public Guid HTSID { get; set; }

        [ForeignKey("HTSID")]
        public virtual HTS HTS { get; set; }

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
