using System;

namespace BackendChallengeAPI.Exceptions
{
    public class InvalidProductStatusException : Exception
    {
        public InvalidProductStatusException()
        {
        }

        public InvalidProductStatusException(string status)
            : base($"Invalid Status: {status}")
        {
        }
    }
}
