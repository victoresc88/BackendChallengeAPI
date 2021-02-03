using BackendChallengeAPI.Exceptions;
using BackendChallengeAPI.ViewModels;

namespace BackendChallengeAPI.Helper
{
    public static class ExceptionHandler
    {
        public static void ValidateProduct(ProductViewModel product)
        {
            if (product?.Id <= 0) 
                throw new InvalidProductIdException(product.Id);
            
            if (string.IsNullOrEmpty(product?.Name))
                throw new InvalidProductNameException(product.Name);

            if (string.IsNullOrEmpty(product?.Status))
                throw new InvalidProductStatusException(product.Status);
            
            if (product?.Rate <= 0)
                throw new InvalidProductRateException(product.Rate);
            
            if (product?.Renewable <= 0)
                throw new InvalidProductRenewableException(product.Renewable);
            
            if (product?.ContractLength <= 0)
                throw new InvalidProductContractLengthException(product.ContractLength);
            
            if (product?.DailyStandingCharge <= 0)
                throw new InvalidProductDailyStandingChargeException(product.DailyStandingCharge);
            
            if (string.IsNullOrEmpty(product?.Supplier))
                throw new InvalidProductSupplierException(product.Supplier);
        }
    }
}
