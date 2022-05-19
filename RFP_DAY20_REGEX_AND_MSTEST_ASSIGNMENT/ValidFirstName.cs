using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RFP_DAY20_REGEX_AND_MSTEST_ASSIGNMENT
{
    class ValidFirstName
    {
        public static string Regex_Name = "^[A-Z][A-Z a-z ]{3,}$";//First character in Upper Case and minimum 3 characters
        public bool Validate_Name(string Name)
        {
         return Regex.IsMatch(Name, Regex_Name);
        }
    }
}
