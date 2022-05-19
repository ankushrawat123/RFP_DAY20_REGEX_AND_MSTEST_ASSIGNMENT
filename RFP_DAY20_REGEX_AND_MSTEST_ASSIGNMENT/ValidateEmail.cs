using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RFP_DAY20_REGEX_AND_MSTEST_ASSIGNMENT
{
    internal class ValidateEmail  //- E.g. abc.xyz@bl.co.in
    {
        public string Regex_Email = "^[a-z A-Z 0-9]+([._#%+][a-z A-Z 0-9]+)?[@][a-z A-z]+[.][a-z A-Z]{2,3}([.][a-z]{2})?$";
        public bool Validate_Email(string Email)
        {
            return Regex.IsMatch(Email, Regex_Email);
        }       
    }
}
