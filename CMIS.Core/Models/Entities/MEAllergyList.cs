using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("MEAllergyList")]
    public class MEAllergyList
    {
        [Key]
        public int MEAllergyListID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Allergy")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public RowSyncStatus SyncStatus { get; set; }

        public virtual IQueryable<MEAllergy> MEAllergy { get; set; }
    }
}
