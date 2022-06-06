using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerMsTest
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void TestMethodHappy()
        {
            InvalidMood moodobjj = new InvalidMood("I am in happy Mood");
            string result = moodobjj.MoodCheck();
            Assert.AreEqual("HAPPY", result.ToUpper());
        }

        [TestMethod]
        public void TestMethodSad()
        {
            InvalidMood moodobjj = new InvalidMood("I am in Sad Mood");
            string result = moodobjj.MoodCheck();
            Assert.AreEqual("SAD", result.ToUpper());
        }

        [TestMethod]
        public void TestMethodNull()
        {
            InvalidMood moodobjj = new InvalidMood(null);
            string result = moodobjj.MoodCheck();
            Assert.AreEqual("HAPPY", result.ToUpper());
        }
    }
}