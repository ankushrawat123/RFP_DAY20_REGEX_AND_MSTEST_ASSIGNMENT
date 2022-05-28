using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class InvalidMood
    {
        string Message;
        public InvalidMood()
        {

        }


        public InvalidMood(string message)
        {
            this.Message = message;
        }

        public string MoodCheck()
        {
            try
            {
                if (this.Message.ToUpper().Contains("SAD"))//null is not string so it will not tested for this and throw exception
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }

            catch (NullReferenceException)
            {
                return "HAPPY";
            }
        }


        //now using constructor with parameter
        public string MoodCheck(string message)
        {
            try
            {
                if (message.ToUpper().Contains("SAD"))//null is not string so it will not tested for this and throw exception
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }

            catch (NullReferenceException)
            {
                return "HAPPY";
            }
        }
    }
}
