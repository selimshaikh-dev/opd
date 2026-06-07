using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("WHOStage")]
    public class WHOStage
    {
        [Key]
        public int WHOStageID { get; set; }

        public int Priority { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "WHO stage")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "T stage")]
        [DataType(DataType.Text)]
        public string TDescription { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<ARTOIList> ARTOIList { get; set; }
    }
}
