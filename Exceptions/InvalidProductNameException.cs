using System;

namespace BackendChallengeAPI.Exceptions
{
    public class InvalidProductNameException : Exception
    {
        public InvalidProductNameException()
        {
        }

        public InvalidProductNameException(string name)
            : base($"Invalid Name: {name}")
        {
        }
    }
}
