using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC1MoodAnilizer;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string expection = "SAD";
            string message = "I am in SAD Mood";
            MoodAnilizer moodanilizer = new MoodAnilizer(message);

            //Act
            string mood = moodanilizer.AnalyserMood();

            //Assert
            Assert.AreEqual(expection, mood);
        }
    }
}
