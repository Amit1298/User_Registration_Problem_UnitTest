using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC2validateLastName
{
    public class ValidateLastName
    {
        public string RegexPattern = "^[A-Z][a-zA-Z]{3,}$";
        public bool lastNameCheck(string lastName)
        {
            return Regex.IsMatch(lastName, RegexPattern);
        }
    }
}
