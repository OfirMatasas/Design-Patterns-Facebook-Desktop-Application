using System;

namespace FacebookExceptions
{
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() : base("User is already logged in to the system.")
        {
        }
    }
}