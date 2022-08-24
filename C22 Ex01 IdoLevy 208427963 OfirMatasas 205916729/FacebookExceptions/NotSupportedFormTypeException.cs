using System;

namespace FacebookExceptions
{
    public class NotSupportedFormTypeException : Exception
    {
        public NotSupportedFormTypeException() : base("This form type is not manufactored in this factory.")
        {
        }
    }
}