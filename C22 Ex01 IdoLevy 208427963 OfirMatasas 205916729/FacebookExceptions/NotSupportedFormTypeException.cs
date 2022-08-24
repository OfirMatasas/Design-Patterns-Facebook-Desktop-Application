using System;

namespace FacebookExceptions
{
    public class NotSupportedFormTypeException : Exception
    {
        public NotSupportedFormTypeException(string i_Message) : base(i_Message)
        {
        }
    }
}