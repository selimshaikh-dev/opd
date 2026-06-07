using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("TBDRRegimenType")]
    public class TBDRRegimenType
    {
        [Key]
        public int TBDRRegimenTypeID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Regimen type")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<TBDR> TBDR { get; set; }
    }
}