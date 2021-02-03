using BackendChallengeAPI.Exceptions;
using BackendChallengeAPI.ViewModels;

namespace BackendChallengeAPI.Helper
{
    public static class ExceptionHandler
    {
        public static void ValidateProduct(ProductViewModel product)
        {
            ValidateId(product.Id);
            ValidateName(product.Name);
            ValidateStatus(product.Status);
            ValidateRate(product.Rate);
            ValidateRenewable(product.Renewable);
            ValidateContractLength(product.ContractLength);
            ValidateDailyStandingCharge(product.DailyStandingCharge);
            ValidateSupplier(product.Supplier);    
        }

        /* More conditions could be added in the 
         * following methods in order to test */
        public static void ValidateId(int id)
        {
            if (id <= 0)
                throw new InvalidProductIdException(id);
        }

        public static void ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new InvalidProductNameException(name);
        }

        public static void ValidateStatus(string status)
        {
            if (string.IsNullOrEmpty(status))
                throw new InvalidProductStatusException(status);
        }

        public static void ValidateRate(double rate)
        {
            if (rate <= 0)
                throw new InvalidProductRateException(rate);
        }

        public static void ValidateRenewable(int renewable)
        {
            if (renewable <= 0)
                throw new InvalidProductRenewableException(renewable);
        }

        public static void ValidateContractLength(int length)
        {
            if (length <= 0)
                throw new InvalidProductContractLengthException(length);
        }

        public static void ValidateDailyStandingCharge(double dailyStandingCharge)
        {
            if (dailyStandingCharge <= 0)
                throw new InvalidProductDailyStandingChargeException(dailyStandingCharge);
        }

        public static void ValidateSupplier(string supplier)
        {
            if (string.IsNullOrEmpty(supplier))
                throw new InvalidProductSupplierException(supplier);
        }
    }
}
