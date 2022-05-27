using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        string Message;
       public MoodAnalyser()
        {

        }
        public MoodAnalyser(string message)
        {
            this.Message = message;
        }
        public string analyseMood()
        {
           
            if (this.Message.ToUpper().Contains("SAD"))
            {
                return "SAD";
            }
            else
            return "HAPPY";
        }
    }
}
