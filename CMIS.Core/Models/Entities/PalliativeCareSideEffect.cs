using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("PalliativeCareSideEffect")]
    public class PalliativeCareSideEffect
    {
        [Key]
        public Guid PalliativeCareSideEffectID { get; set; }

        [Display(Name = "Side effect")]
        public int PalliativeCareSideEffectListID { get; set; }

        [ForeignKey("PalliativeCareSideEffectListID")]
        public virtual PalliativeCareSideEffectList PalliativeCareSideEffectList { get; set; }

        public Guid PalliativeCareID { get; set; }

        [ForeignKey("PalliativeCareID")]
        public virtual PalliativeCare PalliativeCare { get; set; }

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
