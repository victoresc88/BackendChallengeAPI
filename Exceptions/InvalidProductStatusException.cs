using System;

namespace BackendChallengeAPI.Exceptions
{
    public class InvalidProductStatusException : InvalidProductException
    {
        public InvalidProductStatusException()
        {
        }

        public InvalidProductStatusException(string status)
            : base($"Status [{status}] not allowed")
        {
        }
    }
}
