using System;

namespace BackendChallengeAPI.Exceptions
{
    public class InvalidProductNameException : InvalidProductException
    {
        public InvalidProductNameException()
        {
        }

        public InvalidProductNameException(string name)
            : base($"Name [{name}] not allowed")
        {
        }
    }
}
