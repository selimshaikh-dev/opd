using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("ARTOIList")]
    public class ARTOIList
    {
        [Key]
        public int ARTOIListID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Opportunistic infection")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public int WHOStageID { get; set; }

        [ForeignKey("WHOStageID")]
        public virtual WHOStage WHOStage { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<ARTOI> ARTOI { get; set; }
    }
}
