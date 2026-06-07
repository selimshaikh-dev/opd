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
    [Table("ARTAdherence")]
    public class ARTAdherence
    {
        [Key]
        public Guid ARTAdherenceID { get; set; }

        [Required(ErrorMessage = "Required!")]
        [Display(Name = "Counseling Note")]
        [StringLength(600)]
        [DataType(DataType.MultilineText)]
        public string CounselingNote { get; set; }

        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime AdherenceDate { get; set; }

        public Guid ClientID { get; set; }

        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }

        [StringLength(10)]
        public string FacilityCode { get; set; }

        public Guid? VisitID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateCreated { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateModified { get; set; }

        public Guid? ModifiedBy { get; set; }

        public RowStatus? RowStatus { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<ARTAdherenceItem> ARTAdherenceItem { get; set; }
    }
}