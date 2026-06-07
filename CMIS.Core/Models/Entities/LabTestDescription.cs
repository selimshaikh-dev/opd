using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("LabTestDescription")]
    public class LabTestDescription
    {
        [Key]
        public int LabTestDescriptionID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Test description")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public int LabTestCategoryID { get; set; }

        [ForeignKey("LabTestCategoryID")]
        public virtual LabTestCategory LabTestCategory { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<LabTestRequest> LabTestRequest { get; set; }
        public virtual IQueryable<LabTestParameter> LabTestParameter { get; set; }
    }
}
