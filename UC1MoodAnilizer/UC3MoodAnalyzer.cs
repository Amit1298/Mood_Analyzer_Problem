using System;
using System.Collections.Generic;
using System.Text;

namespace UC3enteredInvalidMood
{
    public class UC3MoodAnalyzer
    {
        private string message;
        public UC3MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyserMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalizerCustomException(MoodAnalizerCustomException.ExceptionType.Empty_Message, "Mood should not beEmpty");
                }
                if (this.message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalizerCustomException(MoodAnalizerCustomException.ExceptionType.Empty_Message, "Mood should not beEmpty");
            }


        }
    }
}
