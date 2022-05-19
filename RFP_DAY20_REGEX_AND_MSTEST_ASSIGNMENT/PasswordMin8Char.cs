using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RFP_DAY20_REGEX_AND_MSTEST_ASSIGNMENT
{
    internal class ValidatePassword
    {
        //Minimum 8 characters
        public string Regex_Password = "^[a-z A-Z 0-9 @#%$*!&?]{8,}$";
        public bool Password(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }
}
