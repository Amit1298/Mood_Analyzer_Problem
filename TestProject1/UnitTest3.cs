using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC3enteredInvalidMood;

namespace TestProject3
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        //[DataRow("I am in Happy Mood")]
        //[DataRow(null)]
        public void GivenHappyMoodShouldReturnHappy(string message)
        {
            //Arrange
            string exception = "Happy";
            //string message = "I am in Happy Mood";
            UC3MoodAnalyzer moodanalyser = new UC3MoodAnalyzer(message);

            //Act 
            string mood = moodanalyser.AnalyserMood();
            //Assert
            Assert.AreEqual(exception, mood);
        }
        [TestMethod]
        public void Given_Null_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message = "";
                UC3MoodAnalyzer moodAnalyzer = new UC3MoodAnalyzer(message);
                string mood = moodAnalyzer.AnalyserMood();
            }
            catch (MoodAnalizerCustomException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
        //[TestMethod]
        //public void Given_Null_Mood_Should_Throw_MoodAnalysisException()
        //{
        //    try
        //    {
        //        string message = "";
        //        UC3MoodAnalyzer moodAnalyzer = new UC3MoodAnalyzer(message);
        //        string mood = moodAnalyzer.AnalyserMood();
        //    }
        //    catch (MoodAnalizerCustomException e)
        //    {
        //        Assert.AreEqual("Mood should not be Empty", e.Message);
        //    }
        //}
    }
}
