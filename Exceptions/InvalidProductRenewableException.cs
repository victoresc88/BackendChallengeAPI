using System;

namespace BackendChallengeAPI.Exceptions
{
    public class InvalidProductRenewableException : Exception
    {
        public InvalidProductRenewableException()
        {
        }

        public InvalidProductRenewableException(int renewable)
            : base($"Invalid Renewable: {renewable}")
        {
        }
    }
}
