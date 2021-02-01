using BackendChallengeAPI.Models;
using BackendChallengeAPI.ViewModels;
using System.Collections.Generic;

namespace BackendChallengeAPI.Business
{
    public interface IProductBusiness
    {
        public List<Product> GetListOfAllProducts();
        public List<Product> GetProductsByStatus(string status);
        public List<Product> GetProductsByRenewableRating(double rate);
        public List<Product> GetProductsByContractLength(int length);
        public List<Product> GetProductsBySupplier(string supplier);
        public bool AddProduct(ProductViewModel product);
        public bool UpdateProduct(ProductViewModel product);
        public bool DeleteProduct(int id);
        public double GetProductEstimatedTotalCost(EstimatedTotalCostViewModel estimatedTotalCostViewModel);
    }
}
