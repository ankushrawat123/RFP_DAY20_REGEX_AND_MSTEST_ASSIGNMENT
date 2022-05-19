using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RFP_DAY20_REGEX_AND_MSTEST_ASSIGNMENT
{
    internal class PasswordMin1Num
    {
        public string Regex_Min1NumPwd = "^(?=.*[A-Z])(?=.*[0-9])[a-z A-Z 0-9 $%#@&?*]{8,}";
        public bool Min1NumPwd(string Password)
        {
            return Regex.IsMatch(Password, Regex_Min1NumPwd);
        }
    }
}
