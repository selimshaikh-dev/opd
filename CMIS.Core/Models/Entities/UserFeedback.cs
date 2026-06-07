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
    [Table("UserFeedback")]
    public class UserFeedback
    {
        [Key]
        public Guid UserFeedbackID { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Service Point")]
        public FacilityServicePoints ServicePoint { get; set; }

        [Required(ErrorMessage = "Required!")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        [Display(Name = "Solved")]
        public bool? IsSolved { get; set; }

        [DataType(DataType.MultilineText)]
        public string Response { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ResponseDate { get; set; }

        public Guid? ResponseBy { get; set; }

        [StringLength(10)]
        public string FacilityCode { get; set; }

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
