using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RFP_DAY20_REGEX_AND_MSTEST_ASSIGNMENT
{
    internal class EmailSamples
    {//"^[0-9a-zA-Z]+([+#%&_.-][a-zA-Z0-9]+)*[@][0-9]?[a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$"
        public string Regex_EmailSample = "^[a-z A-Z 0-9]+([.+-_][0-9]{1,})*[@][a-z 0-9]+[.][a-z]{2,3}([.][a-z]{2,3})?$";
        public bool emailSample(string Sample)//    abc111@abc.com
        {
            return Regex.IsMatch(Sample, Regex_EmailSample);
        }
    }
}
