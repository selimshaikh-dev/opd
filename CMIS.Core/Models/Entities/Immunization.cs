using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("Immunization")]
    public class Immunization
    {
        [Key]
        public Guid ImmunizationID { get; set; }

        [Display(Name = "Immunization date")]
        [Column(TypeName = "smalldatetime")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime ImmunizationDate { get; set; }

        [Display(Name = "Immunization status")]
        public bool ImmunizationStatus { get; set; }

        [Display(Name = "Immunization type")]
        public int ImmunizationTypeID { get; set; }

        [ForeignKey("ImmunizationTypeID")]
        public virtual ImmunizationType ImmunizationType { get; set; }

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