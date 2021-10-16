using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC3EmailValidation
{
    public class EmailValidation
    {
        public string RegexPattern = "^[a-zA-Z]+[.]{0,1}[a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}$";
        public bool emailCheck(string email)
        {
            return Regex.IsMatch(email, RegexPattern);
        }
    }
}
