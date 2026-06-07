using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("InpatientAdmission")]
    public class InpatientAdmission
    {
        [Key]
        public Guid InpatientAdmissionID { get; set; }

        [InpatientIfAdmissionDateIsFutureDate]
        [Display(Name = "Admission date")]
        [Column(TypeName = "smalldatetime")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime AdmissionDate { get; set; }

        [Display(Name = "Admission type")]
        [InpatientIfAdmissionTypeNotSelected]
        public AdmissionType AdmissionType { get; set; }

        [InpatientEstimatedDischargeDateLessThanAdmissionDate]
        [Display(Name = "Estimated discharge date")]
        [Column(TypeName = "smalldatetime")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime EstimatedLOS { get; set; }

        [Display(Name = "Procedure date")]
        [Column(TypeName = "smalldatetime")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime? ProcedureDate { get; set; }

        [StringLength(600)]
        [Display(Name = "Procedure description")]
        [DataType(DataType.MultilineText)]
        public string ProcedureDescription { get; set; }

        [StringLength(600)]
        [Display(Name = "Other co-morbidities")]
        [DataType(DataType.MultilineText)]
        public string OtherCoMorbidities { get; set; }

        [InpatientIfDischargeDateIsFutureDate]
        [Display(Name = "Discharge date")]
        [Column(TypeName = "smalldatetime")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime? DischargeDate { get; set; }

        [Display(Name = "Discharge Status")]
        public int? InpatientDischargeStatusID { get; set; }

        [ForeignKey("InpatientDischargeStatusID")]
        public virtual InpatientDischargeStatus InpatientDischargeStatus { get; set; }

        public Guid ClientID { get; set; }

        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }

        [StringLength(10)]
        public string FacilityCode { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateCreated { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateModified { get; set; }

        public Guid? ModifiedBy { get; set; }

        public RowStatus? RowStatus { get; set; }

        public RowSyncStatus SyncStatus { get; set; }

        public Guid? VisitID { get; set; }
    }
}