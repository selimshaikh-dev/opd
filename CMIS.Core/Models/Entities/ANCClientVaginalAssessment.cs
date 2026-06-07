using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMIS.Core.Models.Entities
{
    [Table("ANCClientVaginalAssessment")]
    public class ANCClientVaginalAssessment
    {
        public Guid ANCClientVaginalAssessmentID { get; set; }

        [Display(Name = "ANC Vaginal Assessment")]
        public int ANCVaginalAssessmentID { get; set; }

        [ForeignKey("ANCVaginalAssessmentID")]
        public virtual ANCVaginalAssessment ANCVaginalAssessment { get; set; }

        public Guid ANCID { get; set; }

        [ForeignKey("ANCID")]
        public virtual ANC ANC { get; set; }

    }
}
