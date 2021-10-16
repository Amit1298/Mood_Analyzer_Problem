using System;
using System.Collections.Generic;
using System.Text;

namespace UC3enteredInvalidMood
{
    public class MoodAnalizerCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, Empty_Message,
            NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        private readonly ExceptionType type;
        public MoodAnalizerCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
