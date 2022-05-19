using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RFP_DAY20_REGEX_AND_MSTEST_ASSIGNMENT
{
    internal class PWD_Special_Char
    {
        public string Regex_SpecialChar_Pwd = "^(?=.*[*&^%$#@!?_-])(?=.*[0-9])(?=.*[A-Z])(?=.[a-z A-Z 0-9]{8,}).*$";// $2ankush
        public bool one_SpecialChar_Pwd(string PWD)
        {
            return Regex.IsMatch(Regex_SpecialChar_Pwd, PWD);
        }
    }
}
