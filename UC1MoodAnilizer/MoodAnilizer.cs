using System;
using System.Collections.Generic;
using System.Text;

namespace UC1MoodAnilizer
{
    public class MoodAnilizer
    {
        private string message;
        public MoodAnilizer(string message)
        {
            this.message = message;
        }
        public string AnalyserMood()
        {
            if(this.message.Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
