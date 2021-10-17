using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC6AtLeast1UpperCase
{
    public class UpperCaseValidate
    {
        public string RegexPattern = "^[A-Z]{1}[a-zA-Z0-9]{7,}$";
        public bool UpperCaseCheck(string UCase)
        {
            return Regex.IsMatch(UCase, RegexPattern);
        }
    }
}
