using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("PalliativeCare")]
    public class PalliativeCare
    {
        [Key]
        public Guid PalliativeCareID { get; set; }

        [Display(Name = "Received laxative")]
        public YesNo ReceivedLaxative { get; set; }

        [StringLength(600)]
        [Display(Name = "Reported side effects")]
        [DataType(DataType.MultilineText)]
        public string ReportedSideEffects { get; set; }

        [StringLength(600)]
        [Display(Name = "Comments")]
        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }

        [Display(Name = "Diagnosis")]
        public int PalliativeCareDiagnosisID { get; set; }

        [ForeignKey("PalliativeCareDiagnosisID")]
        public virtual PalliativeCareDiagnosis PalativeCareDiagnosis { get; set; }

        [Display(Name = "Pain score")]
        public int PalliativeCarePainScoreID { get; set; }

        [ForeignKey("PalliativeCarePainScoreID")]
        public virtual PalliativeCarePainScore PalliativeCarePainScore { get; set; }

        [Display(Name = "Pyscho social support")]
        public int PalliativeCarePsychoSocialSupportID { get; set; }

        [ForeignKey("PalliativeCarePsychoSocialSupportID")]
        public virtual PalliativeCarePsychoSocialSupport PalliativeCarePsychoSocialSupport { get; set; }

        [Display(Name = "Outcome")]
        public int PalliativeCareOutcomeID { get; set; }

        [ForeignKey("PalliativeCareOutcomeID")]
        public virtual PalliativeCareOutcome PalliativeCareOutcome { get; set; }

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

        public virtual IQueryable<PalliativeCareSideEffect> PalliativeCareSideEffects { get; set; }
    }
}
