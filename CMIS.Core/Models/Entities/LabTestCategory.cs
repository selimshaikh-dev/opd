using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("LabTestCategory")]
    public class LabTestCategory
    {
        [Key]
        public int LabTestCategoryID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Test category")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        //public int LabSpecimenID { get; set; }

        //[ForeignKey("LabSpecimenID")]
        //public virtual LabSpecimen LabSpecimen { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<LabTestDescription> LabTestDescription { get; set; }
    }
}
