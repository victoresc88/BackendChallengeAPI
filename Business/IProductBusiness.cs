using BackendChallengeAPI.Models;
using BackendChallengeAPI.ViewModels;
using System.Collections.Generic;

namespace BackendChallengeAPI.Business
{
    public interface IProductBusiness
    {
        public IEnumerable<Product> GetListOfAllProducts();
        public IEnumerable<Product> GetProductsByStatus(string status);
        public IEnumerable<Product> GetProductsByRenewableRating(double rate);
        public IEnumerable<Product> GetProductsByContractLength(int contractLength);
        public IEnumerable<Product> GetProductsBySupplier(string supplier);
        public bool AddProduct(Product product);
        public bool UpdateProduct(Product product);
        public bool DeleteProduct(int id);
        public double GetProductEstimatedTotalCost(EstimatedTotalCostViewModel estimatedTotalCostViewModel);
    }
}
