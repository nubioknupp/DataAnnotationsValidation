using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationsTest.Validation
{
    public class DataAnnotationsValidationResult
    {
        public DataAnnotationsValidationResult()
        {
            IsValid = true;
            Errors = new List<ValidationResult>();
        }

        public bool IsValid { get; set; } 
        public IEnumerable<ValidationResult> Errors { get; set; }
    }
}