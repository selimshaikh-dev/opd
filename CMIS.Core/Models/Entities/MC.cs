using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("MC")]
    public class MC
    {
        [Key]
        public Guid MCID { get; set; }

        [IfYesNoNotSelected]
        [Display(Name = "Treated for STIs")]
        public YesNo TreatedForSTI { get; set; }

        [IfYesNoNotSelected]
        [Display(Name = "Past surgical operation")]
        public YesNo PastSurgicalOperation { get; set; }

        [MCIfSurgeryDateIsFutureDate]
        [Display(Name = "Surgery Date")]
        [Column(TypeName = "smalldatetime")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? SurgeryDate { get; set; }

        [Display(Name = "Type of surgery")]
        [StringLength(300)]
        [DataType(DataType.MultilineText)]
        public string TypeOfSurgery { get; set; }

        [Required]
        [MCIfMCDateIsFutureDate]
        [Display(Name = "MC Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        public DateTime MCDate { get; set; }

        [Display(Name = "Marcaine 0.5%")]
        public decimal? Marcaine { get; set; }

        [Display(Name = "DPNB")]
        public decimal? DPNB { get; set; }

        [Display(Name = "DPNB + Ringblock")]
        public decimal? DPNBRingblock { get; set; }

        [Display(Name = "Lignocaine 1%")]
        public decimal? LignocaineOne { get; set; }

        [Display(Name = "Lignocaine 2%")]
        public decimal? LignocaineTwo { get; set; }

        [Display(Name = "Diathermy used")]
        public YesNo DiathermyUsed { get; set; }

        public decimal? Frequency { get; set; }

        public decimal? Cut { get; set; }

        public decimal? Coagulation { get; set; }

        public int MCProcedureID { get; set; }

        [ForeignKey("MCProcedureID")]
        public virtual MCProcedure MCProcedure { get; set; }

        public int MCMethodID { get; set; }

        [ForeignKey("MCMethodID")]
        public virtual MCMethod MCMethod { get; set; }

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

        public virtual IQueryable<MCComplaintList> MCComplaintList { get; set; }

        public virtual IQueryable<MCPhysicalExaminationList> MCPhysicalExaminationList { get; set; }
    }
}
