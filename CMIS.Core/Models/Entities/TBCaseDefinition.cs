using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("TBCaseDefinition")]
    public class TBCaseDefinition
    {
        [Key]
        public int TBCaseDefinitionID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Case definition")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<TBDS> TBDS { get; set; }
        public virtual IQueryable<TBDR> TBDR { get; set; }
    }
}
