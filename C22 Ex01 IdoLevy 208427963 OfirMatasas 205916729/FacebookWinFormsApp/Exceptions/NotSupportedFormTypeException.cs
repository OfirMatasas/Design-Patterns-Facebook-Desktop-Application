using System;

namespace BasicFacebookFeatures.Exceptions
{
    public class NotSupportedFormTypeException : Exception
    {
        public NotSupportedFormTypeException(string i_Message) : base(i_Message)
        {
        }
    }
}