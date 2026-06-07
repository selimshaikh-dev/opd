using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMIS.Core.Models.Entities
{
    [Table("RecoveryRequest")]
    public class RecoveryRequest
    {
        [Key]
        public Guid RecoveryRequestID { get; set; }

        [Display(Name = "Username")]
        [StringLength(30, ErrorMessage = "Username cannot exceed 30 characters")]
        public string Username { get; set; }

        [Display(Name = "National ID")]
        [StringLength(13, ErrorMessage = "National ID cannot exceed 13 characters")]
        public string PIN { get; set; }

        [Display(Name = "Cellphone")]
        [Required(ErrorMessage = "Required !")]
        [StringLength(13, ErrorMessage = "Cellphone cannot exceed 13 characters")]
        public string Cellphone { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateRequested { get; set; }

        public bool IsRequestOpen { get; set; }

        public Guid UserID { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
}
