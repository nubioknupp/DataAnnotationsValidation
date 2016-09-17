using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationsTest.Validation
{
    public static class DataAnnotationsValidation<TEntity>
    {
        public static DataAnnotationsValidationResult Validate(TEntity obj)
        {
            var context = new ValidationContext(obj, null, null);
            var errors = new List<ValidationResult>();
            var validationResult = new DataAnnotationsValidationResult();
            var tryValidateObject = Validator.TryValidateObject(obj, context, errors, true);

            if (tryValidateObject) return validationResult;

            validationResult.Errors = errors;
            validationResult.IsValid = false;

            return validationResult;
        }
    }
}