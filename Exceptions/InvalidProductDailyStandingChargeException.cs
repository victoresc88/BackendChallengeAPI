using System;

namespace BackendChallengeAPI.Exceptions
{
    public class InvalidProductDailyStandingChargeException : InvalidProductException
    {
        public InvalidProductDailyStandingChargeException()
        {
        }

        public InvalidProductDailyStandingChargeException(double dailyStandingCharge)
            : base($"Daily Standing Charge [{dailyStandingCharge}] not allowed")
        {
        }
    }
}
