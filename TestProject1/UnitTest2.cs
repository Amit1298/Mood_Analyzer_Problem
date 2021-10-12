using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC2ExceptionMoodAnalyzer;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("I am in Happy Mood")]
        [DataRow(null)]
        public void TestMethod1(string message)
        {
            //Arrange
            string exception = "Happy";
            //string message = "I am in Happy Mood";
            UC2MoodAnalyzer moodanalyser = new UC2MoodAnalyzer(message);

            //Act 
            string mood = moodanalyser.AnalyserMood();

            //Assert
            Assert.AreEqual(exception, mood);
        }
    }
}
