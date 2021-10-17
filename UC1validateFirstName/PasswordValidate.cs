using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC5password
{
    public class PasswordValidate
    {
        public string RegexPattern = "^[a-zA-Z0-9]{8,}$";
        public bool passwordCheck(string password)
        {
            return Regex.IsMatch(password, RegexPattern);
        }
    }
}
