using System;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsTest.Validation;

namespace DataAnnotationsTest
{
    public class Contact
    {
        [Required(ErrorMessage = "Preencha o campo First name")]
        [MaxLength(30, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(10, ErrorMessage = "Mínimo {0} caracteres")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Birthday { get; set; }

        public DataAnnotationsValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            ValidationResult = DataAnnotationsValidation<Contact>.Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
