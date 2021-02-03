using System;

namespace BackendChallengeAPI.Exceptions
{
    public class InvalidProductDailyStandingChargeException : Exception
    {
        public InvalidProductDailyStandingChargeException()
        {
        }

        public InvalidProductDailyStandingChargeException(double dailyStandingCharge)
            : base($"Invalid Daily Standing Charge: {dailyStandingCharge}")
        {
        }
    }
}
