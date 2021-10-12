using System;
using System.Collections.Generic;
using System.Text;

namespace UC2ExceptionMoodAnalyzer
{
    public class UC2MoodAnalyzer
    {
        private string message;
        public UC2MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyserMood()
        {
            try
            {
                if (this.message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch
            {
                return "Happy";
            }


        }
    }
}
