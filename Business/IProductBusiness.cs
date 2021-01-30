using BackendChallengeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendChallengeAPI.Business
{
    public interface IProductBusiness
    {
        public IEnumerable<Product> GetListOfAllProducts();
        public IEnumerable<Product> GetProductsByStatus(string status);
        public IEnumerable<Product> GetProductsByRenewableRating(decimal rate);
        public IEnumerable<Product> GetProductsByContractLength(int contractLength);
        public IEnumerable<Product> GetProductsBySupplier(string supplier);
        public bool AddProduct(Product product);
        public bool UpdateProduct(Product product);
        public bool DeleteProduct(int id);
        public decimal GetProductEstimatedTotalCost(Product product, decimal estimatedConsumption);
    }
}
