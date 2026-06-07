using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("CervicalAbnormality")]
    public class CervicalAbnormality
    {
        [Key]
        public int CervicalAbnormalityID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Cervical cancer abnormality")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<CervicalCancerAbnormality> CervicalCancerAbnormalities { get; set; }
    }
}