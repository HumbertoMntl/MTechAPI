using System.Text.RegularExpressions;
namespace MTech.Utils
{
    // Utility class for validating the format of a RFC.
    public static class RfcValidator
    {
        // Returns true if the provided RFC matches the required format.
        public static bool IsValid(string rfc)
        {
            if (string.IsNullOrEmpty(rfc))
                return false;
            // Regex: 3-4 letters, 6 digits (date), 3 alphanumeric (homoclave)
            return Regex.IsMatch(rfc, @"^[A-ZÑ&]{3,4}\d{6}[A-Z0-9]{3}$", RegexOptions.IgnoreCase);
        }
    }
}
