using System;

namespace BackendChallengeAPI.Exceptions
{
    public class InvalidProductRateException : InvalidProductException
    {
        public InvalidProductRateException()
        {
        }

        public InvalidProductRateException(double rate)
            : base($"Rate [{rate}] not allowed")
        {
        }
    }
}
