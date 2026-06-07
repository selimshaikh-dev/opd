using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("LabTestParameter")]
    public class LabTestParameter
    {
        public int LabTestParameterID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public int LabTestDescriptionID { get; set; }

        [ForeignKey("LabTestDescriptionID")]
        public virtual LabTestDescription LabTestDescription { get; set; }

        public YesNo IsRequired { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }
    }
}
