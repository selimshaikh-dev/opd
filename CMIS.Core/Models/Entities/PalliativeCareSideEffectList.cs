using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("PalliativeCareSideEffectList")]
    public class PalliativeCareSideEffectList
    {
        [Key]
        public int PalliativeCareSideEffectListID { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(90)]
        [Display(Name = "Side effect")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }
    }
}
