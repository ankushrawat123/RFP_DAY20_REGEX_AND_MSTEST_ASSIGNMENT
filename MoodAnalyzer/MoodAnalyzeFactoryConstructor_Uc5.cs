using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    internal class MoodAnalyzeFactoryConstructor
    {
       
            public string ClassName;
            public string Constructor;
            public MoodAnalyzeFactoryConstructor(string className, string constructor)
            {
                this.ClassName = className;
                this.Constructor = constructor;
            }


            public static object FactoryMethod(MoodAnalyzeFactoryConstructor factory, string message)
            {
                if ("MoodAnalyze3" == factory.Constructor)
                {
                    try
                    {
                        /*Assembly executing = Assembly.GetExecutingAssembly();
                        Type AnaylseType = executing.GetType(factory.ClassName);
                        var MyObj= Activator.CreateInstance(AnaylseType);
                        return MyObj;*/

                        Assembly executing = Assembly.GetExecutingAssembly();
                        Type AnaylseType = executing.GetType(factory.ClassName);
                        ConstructorInfo ctor = AnaylseType.GetConstructor(new[] { typeof(string) });
                        object MyObj = ctor.Invoke(new object[] { message });
                        return MyObj;
                    }
                    catch
                    {
                        throw new CustomException(CustomException.ExceptionType.CLASS_NOT_FOUND, "class name is wrong");
                    }
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "constructor name is wrong");
                }
            }
    }
    
}
