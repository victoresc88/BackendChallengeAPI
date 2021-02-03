
namespace BackendChallengeAPI.Exceptions
{
    public class InvalidProductSupplierException : InvalidProductException
    {
        public InvalidProductSupplierException()
        {
        }

        public InvalidProductSupplierException(string supplier) 
            : base($"Supplier [{supplier}] not allowed")
        {
        }
    }
}
