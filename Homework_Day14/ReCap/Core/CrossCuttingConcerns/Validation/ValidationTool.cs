using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);      // burada ben car için doğrulama yapacağım diyoruz
            var result = validator.Validate(context);
            if (!result.IsValid)    // sonuç geçerli değil ise hata fırlat
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
