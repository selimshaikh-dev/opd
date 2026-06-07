using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("UserAccess")]
    public class UserAccess
    {
        [Key]
        public Guid UserAccessID { get; set; }

        [Required(ErrorMessage = "Required!")]
        public byte Module { get; set; }

        public Guid UserID { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }
    }
}