using System;

namespace FacebookExceptions
{
    public class LoginFailureException : Exception
    {
        public LoginFailureException() : base("Failed logging into the system.")
        {
        }
    }
}