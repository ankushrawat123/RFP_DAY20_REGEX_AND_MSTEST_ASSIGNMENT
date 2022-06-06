using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyze3
    {
        string Message;
        public MoodAnalyze3()
        {

        }
        public MoodAnalyze3(string message)
        {
            this.Message= message;
        }
        public string analyzeMood3()
        {
            try
            {
                if (this.Message.ToUpper().Contains("SAD"))
                {
                    return "SAD";
                }
                else if (this.Message.ToUpper().Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.Empty_Message, "Message should not be Empty");
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.Null_Message, "Message should not be null");
            }
        }
         
    }
}
