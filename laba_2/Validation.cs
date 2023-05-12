using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace laba_2
{
    internal static class Validation
    {
        public static void MyValidation(this IValidateble validate )
        {
            ValidationContext TryVal = new ValidationContext(validate);
            List<ValidationResult> validationRes = new List<ValidationResult>();
            if (Validator.TryValidateObject(validate, TryVal, validationRes, true))
            {
                Console.WriteLine("Валидация прошла успешно");
            }
            else
            {
                Console.WriteLine("Валидация не пройдена");
            }
        }
    }
}
