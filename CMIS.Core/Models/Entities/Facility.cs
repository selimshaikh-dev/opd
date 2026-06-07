using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("Facility")]
    public class Facility
    {
        [Key]
        public int FacilityID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Facility name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(20)]
        [Display(Name = "Facility code")]
        [DataType(DataType.Text)]
        public string FacilityCode { get; set; }

        [StringLength(20)]
        public string Longitude { get; set; }

        [StringLength(20)]
        public string Latitude { get; set; }

        public Region Region { get; set; }

        [StringLength(13)]
        public string Telephone { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateCreated { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateModified { get; set; }

        public Guid? ModifiedBy { get; set; }

        public RowStatus? RowStatus { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<ReferralFacility> ReferralFacility { get; set; }
        public virtual IQueryable<User> Users { get; set; }
    }
}
