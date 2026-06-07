using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("Designation")]
    public class Designation
    {
        [Key]
        public int DesignationID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(60)]
        [Display(Name = "Designation")]
        [DataType(DataType.Text)]
        public string DesignationName { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<User> Users { get; set; }
    }
}
