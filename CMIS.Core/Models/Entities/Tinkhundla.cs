using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("Tinkhundla")]
    public class Tinkhundla
    {
        [Key]
        public int TinkhundlaID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Inkhundla name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<ReferralCommunity> ReferralCommunity { get; set; }
    }
}
