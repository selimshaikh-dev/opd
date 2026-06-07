using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMIS.Core.Models.Entities
{
    [Table("ARTAdherenceItem")]
    public class ARTAdherenceItem
    {
        [Key]
        public Guid ARTAdherenceItemID { get; set; }

        public int ARTAdherenceListID { get; set; }

        [ForeignKey("ARTAdherenceListID")]
        public virtual ARTAdherenceList ARTAdherenceList { get; set; }

        public Guid ARTAdherenceID { get; set; }

        [ForeignKey("ARTAdherenceID")]
        public virtual ARTAdherence ARTAdherence { get; set; }
    }
}