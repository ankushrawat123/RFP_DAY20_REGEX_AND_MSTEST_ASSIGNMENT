using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerMsTest
{
    [TestClass]
    public class CustormExceptionTest_Uc3
    {
        [TestMethod]
        public void TestMethodHappy3()
        {
            MoodAnalyze3 tMoodObj3 = new MoodAnalyze3("I am in Happy Mood");
            string result = tMoodObj3.analyzeMood3();
            Assert.AreEqual("HAPPY",result.ToUpper());
        }

        [TestMethod]
        public void TestMethodSad3()
        {
            MoodAnalyze3 tMoodObj3 = new MoodAnalyze3("I am in Sad Mood");
            string result = tMoodObj3.analyzeMood3();
            Assert.AreEqual("SAD", result.ToUpper());
        }

        [TestMethod]
        public void CustomExceptionNull3()
        {
            try
            {
                MoodAnalyze3 tMoodObj3 = new MoodAnalyze3();
                string result = tMoodObj3.analyzeMood3();
            }
            catch (Exception ex)
            {
                Assert.AreEqual("message should not be null",ex.Message);
            }
        }

        [TestMethod]
        public void CustomExceptionEmpty3()
        {
            try
            {
                MoodAnalyze3 tMoodObj3 = new MoodAnalyze3("");
                string result = tMoodObj3.analyzeMood3();
            }
            catch (Exception ex)
            {
                Assert.AreEqual("message should not be empty",ex.Message);
            }
        }
    }
}
