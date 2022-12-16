using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.Eshop.Domain.Validation
{
    public class LowerCasesAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }
            else if(value is string text)
            {
                if(text == text.ToLower())
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult($"{validationContext.MemberName}: the field doesn't have lower cases only!");
                }
            }
            else
            {
                throw new NotImplementedException($"{nameof(LowerCasesAttribute)} does not implement validation for the type: {value.GetType()}");
            }
        }
    }
}
