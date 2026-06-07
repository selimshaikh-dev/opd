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
    [Table("PNCChildConditionOfUmbilicalCord")]
    public class PNCChildConditionOfUmbilicalCord
    {
        [Key]
        public int PNCChildConditionOfUmbilicalCordID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Condition of umbilical cord")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<PNCChild> PNCChild { get; set; }
    }
}
