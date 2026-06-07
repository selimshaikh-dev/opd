using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("MCMethod")]
    public class MCMethod
    {
        [Key]
        public int MCMethodID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "MC method")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<MC> MC { get; set; }
    }
}
