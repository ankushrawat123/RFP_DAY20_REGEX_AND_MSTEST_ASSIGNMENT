using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzerFactory
    {
        public string ClassName;
        public string Constructor;
        public MoodAnalyzerFactory(string ClassName, string constructor)
        {
            this.ClassName = ClassName;
            this.Constructor = constructor; 
        }
        public static object FactoryMethod(MoodAnalyzerFactory factory)
        {
            if ("MoodAnalyze3" == factory.Constructor)
            {
                try
                {
                    AssemblyLoadEventArgs executing = Assembly.GetExecutingAssembly();
                    Type AnalyseType = executing.GetType(factory.ClassName);
                    var MyObj = Activator.CreateInstance(AnalyseType);
                    return MyObj;
                }
                catch
                {
                    throw new CustomException(CustomException.ExceptionType.CLASS_NOT_FOUND, "Class name is wrong");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "Constructor name is wrong");
            }

        }
       

    }
}
