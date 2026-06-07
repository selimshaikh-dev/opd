using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("DrugDescription")]
    public class DrugDescription
    {
        [Key]
        public int DrugDescriptionID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Drug description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public int? DrugFormID { get; set; }

        [ForeignKey("DrugFormID")]
        public virtual DrugForm DrugForm { get; set; }

        [Display(Name = "Drug group")]
        public int DrugGroupID { get; set; }

        [ForeignKey("DrugGroupID")]
        public virtual DrugGroup DrugGroup { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<Medication> Medications { get; set; }

        public virtual IQueryable<OutOfStockDrugList> OutOfStockDrugList { get; set; }

    }
}