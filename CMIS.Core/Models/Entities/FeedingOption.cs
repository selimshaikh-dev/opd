using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("FeedingOption")]
    public class FeedingOption
    {
        [Key]
        public int FeedingOptionID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Feeding option")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<Maternity> Maternity { get; set; }
        public virtual IQueryable<ChildWelfare> ChildWelfare { get; set; }
        public virtual IQueryable<PNCChild> PNCChild { get; set; }
    }
}
