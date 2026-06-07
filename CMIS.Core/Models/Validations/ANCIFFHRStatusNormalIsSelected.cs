using CMIS.Core.Constants;
using CMIS.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMIS.Core.Models.Validations
{
    public class ANCIFFHRStatusNormalIsSelected : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var anc = (ANC)validationContext.ObjectInstance;

            if (anc.ANCFHRID == int.Parse(ConfigurationManager.AppSettings[CMISConstants.FHRStatus]) && anc.ANCFHR == null)
            {
                return new ValidationResult("Required!");
            }

            return ValidationResult.Success;
        }
    }
}