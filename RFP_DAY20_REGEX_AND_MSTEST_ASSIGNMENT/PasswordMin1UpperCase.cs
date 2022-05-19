using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RFP_DAY20_REGEX_AND_MSTEST_ASSIGNMENT
{
    internal class PasswordMin1UpperCase
    {
        public String Regex_Pwd_1UpperCase = "^(?=.*[A-Z])[A-Z a-z 0-9 $#@!&*?|]{8,}$";
        public bool PwdUpperCase(string PwdUpperCase)
        {
            return Regex.IsMatch(PwdUpperCase, Regex_Pwd_1UpperCase);
        }
    }
}
