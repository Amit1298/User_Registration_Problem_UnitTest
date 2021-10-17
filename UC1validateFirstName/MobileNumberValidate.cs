using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC4mobileNumberValidate
{
    public class MobileNumberValidate
    {
        public string RegexPattern = "^[9]{1}[1]{1}[ ][0-9]{10}$";
        public bool phoneNumberCheck(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, RegexPattern);
        }
    }
}
