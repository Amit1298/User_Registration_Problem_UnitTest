using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC1validateFirstName
{
    public class ValidateFirstName
    {
        public string RegexPattern = "^[A-Z][a-zA-Z]{3,}$";
        public bool firstNameCheck(string firstName)
        {
            return Regex.IsMatch(firstName, RegexPattern);
        }
    }
}
