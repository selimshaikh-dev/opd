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
    [Table("IndexClient")]
    public class IndexClient
    {
        [Key]
        public Guid IndexClientID { get; set; }

        [StringLength(20)]
        [Display(Name = "Inviter's index code")]
        public string IndexCodeInviter { get; set; }

        [StringLength(20)]
        [Display(Name = "Inviter's index code")]
        public string IndexCodeInvitee { get; set; }

        public IndexModule IndexModule { get; set; }

        [Display(Name = "Number of invitees")]
        public int? NumberOfInvitees { get; set; }

        [Display(Name = "Client ID")]
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
    }
}
