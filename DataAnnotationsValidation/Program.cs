using System;
using static System.Console;

namespace DataAnnotationsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var contact = new Contact { FirstName = "Armin", LastName = "Zia", Birthday = new DateTime(1988, 04, 20) };

            if (!contact.IsValid())
            {
                foreach (var result in contact.ValidationResult.Errors) WriteLine(result.ErrorMessage);
            }
            else
            {
                WriteLine("Validated");
            }

            ReadLine();
        }

    }
}
