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
    [Table("ARTOI")]
    public class ARTOI
    {
        [Key]
        public Guid ARTOIID { get; set; }

        public int ARTOIListID { get; set; }

        [ForeignKey("ARTOIListID")]
        public virtual ARTOIList ARTOIList { get; set; }

        public Guid ARTID { get; set; }

        [ForeignKey("ARTID")]
        public virtual ART ART { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }
    }
}