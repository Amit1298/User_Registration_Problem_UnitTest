using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC7Atleast1NumericNumber
{
    public class NumericNumberValidate
    {
        public string RegexPattern = "^[a-zA-Z0-9]{7,}[0-9]{1}$";
        public bool numericCheck(string numericNumber)
        {
            return Regex.IsMatch(numericNumber, RegexPattern);
        }
    }
}
