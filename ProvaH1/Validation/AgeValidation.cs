using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;

namespace ProvaH1.Validation
{
    public class AgeValidation: ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null)
                return false;

            return (int)value <= 18 && (int)value >0;
        }

    }
}
