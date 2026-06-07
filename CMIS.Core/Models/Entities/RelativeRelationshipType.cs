using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("RelativeRelationshipType")]
    public class RelativeRelationshipType
    {
        [Key]
        public int RelativeRelationshipTypeID { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Relationship type")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<Relative> Relatives { get; set; }
    }
}
