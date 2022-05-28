using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            Null_Message, Empty_Message
        }
        
        public ExceptionType Type;
        public CustomException(ExceptionType type, string message): base(message)
        {
            Type = type;
        }
    }
}
