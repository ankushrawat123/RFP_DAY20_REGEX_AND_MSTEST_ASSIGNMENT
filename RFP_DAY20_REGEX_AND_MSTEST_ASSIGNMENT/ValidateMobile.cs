using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RFP_DAY20_REGEX_AND_MSTEST_ASSIGNMENT
{
    internal class ValidateMobile
    {
        public string Regex_Mobile = "^91[ ][1-9][0-9]{9}$";
        public bool Validate_Mobile(string Mobile)
        {
            return Regex.IsMatch(Mobile, Regex_Mobile);
        }
    }
}
