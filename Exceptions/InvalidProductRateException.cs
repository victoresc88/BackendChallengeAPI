using System;

namespace BackendChallengeAPI.Exceptions
{
    public class InvalidProductRateException : Exception
    {
        public InvalidProductRateException()
        {
        }

        public InvalidProductRateException(double rate)
            : base($"Invalid Rate: {rate}")
        {
        }
    }
}
