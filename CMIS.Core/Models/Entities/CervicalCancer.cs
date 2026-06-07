using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("CervicalCancer")]
    public class CervicalCancer
    {
        [Key]
        public Guid CervicalCancerID { get; set; }

        [Display(Name = "PAP smear result")]
        [CervicalCancerIfPAPSmearResultNotSelected]
        public PAPSmearResult PAPSmearResult { get; set; }

        [Display(Name = "VIA result")]
        [CervicalCancerIfVIAResultNotSelected]
        public VIAResult VIAResult { get; set; }

        [Display(Name = "Palpation exam done")]
        public YesNo PalpationExamDone { get; set; }

        [IfYesNoNotSelected]
        [Display(Name = "Breast palpation exam")]
        public YesNo BreastPalpationExamDone { get; set; }

        [IfYesNoNotSelected]
        [Display(Name = "Biopsy done")]
        public YesNo BiopsyDone { get; set; }

        [StringLength(200)]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [Display(Name = "Treatment given")]
        public int CervicalTreatmentID { get; set; }

        [ForeignKey("CervicalTreatmentID")]
        public virtual CervicalTreatment CervicalTreatment { get; set; }

        public Guid ClientID { get; set; }

        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }

        [Display(Name = "Lab request result")]
        public int? CervicalCancerTestResultID { get; set; }

        [ForeignKey("CervicalCancerTestResultID")]
        public virtual CervicalCancerTestResult CervicalCancerTestResult { get; set; }

        [CervicalCancerIfBiopsyResultNotSelected]
        [Display(Name = "Biopsy Result")]
        public int? CervicalCancerBiopsyResultID { get; set; }

        [ForeignKey("CervicalCancerBiopsyResultID")]
        public virtual CervicalCancerBiopsyResult CervicalCancerBiopsyResult { get; set; }

        [Display(Name = "Cervical Abnormalities")]
        public YesNo CervicalAbnormalities { get; set; }

        public virtual IQueryable<CervicalCancerAbnormality> CervicalCancerAbnormalities { get; set; }

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