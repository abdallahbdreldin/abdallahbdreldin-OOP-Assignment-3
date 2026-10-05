using System.Text.RegularExpressions;

namespace ExtensionMethods
{
    public static class StringValidationExtensions
    {
        extension(string? value)
        {
            public bool IsValidEgyptianPhone()
            {
                return value != null &&
                       Regex.IsMatch(
                           value,
                           @"^(010|011|012|015)\d{8}$|^\+20(10|11|12|15)\d{8}$");
            }
            public bool IsValidEgyptianNationalId()
            {
                return value != null &&
                       Regex.IsMatch(
                           value,
                           @"^[23]\d{13}$");
            }
        }

    }
}
