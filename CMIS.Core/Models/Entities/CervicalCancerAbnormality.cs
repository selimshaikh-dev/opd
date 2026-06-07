using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMIS.Core.Models.Entities
{
    [Table("CervicalCancerAbnormality")]
    public class CervicalCancerAbnormality
    {
        [Key]
        public Guid CervicalCancerAbnormalityID { get; set; }

        [Display(Name = "Cervical abnormality")]
        public int CervicalAbnormalityID { get; set; }

        [ForeignKey("CervicalAbnormalityID")]
        public virtual CervicalAbnormality CervicalAbnormality { get; set; }

        public Guid CervicalCancerID { get; set; }

        [ForeignKey("CervicalCancerID")]
        public virtual CervicalCancer CervicalCancer { get; set; }
    }
}