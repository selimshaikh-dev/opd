using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("Chiefdom")]
    public class Chiefdom
    {
        [Key]
        public int ChiefdomID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [StringLength(90)]
        [Display(Name = "Chiefdom")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public int TinkhundlaID { get; set; }

        [ForeignKey("TinkhundlaID")]
        public virtual Tinkhundla Tinkhundla { get; set; }

        public virtual IQueryable<Client> Clients { get; set; }
    }
}
