using CMIS.Core.Constants;
using CMIS.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMIS.Core.Models.Validations
{
    public class ANCEDDDateLessThanLMPDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var anc = (ANC)validationContext.ObjectInstance;

            if (anc.LastKnownMenstrualPeriod.Date > anc.ExpectedDeliveryDate.Date)
                return new ValidationResult(MessageText.EDDDateLessThanLMPDate);

            return ValidationResult.Success;
        }
    }
}