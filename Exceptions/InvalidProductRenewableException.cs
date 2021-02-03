using System;

namespace BackendChallengeAPI.Exceptions
{
    public class InvalidProductRenewableException : InvalidProductException
    {
        public InvalidProductRenewableException()
        {
        }

        public InvalidProductRenewableException(int renewable)
            : base($"Renewable [{renewable}] not allowed")
        {
        }
    }
}
