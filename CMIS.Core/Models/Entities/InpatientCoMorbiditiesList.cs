using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("InpatientCoMorbiditiesList")]
    public class InpatientCoMorbiditiesList
    {
        [Key]
        public int InpatientCoMorbiditiesListID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(30)]
        [Display(Name = "Co-Morbidities")]
        public string Description { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<InpatientCoMorbidities> InpatientCoMorbidities { get; set; }
    }
}