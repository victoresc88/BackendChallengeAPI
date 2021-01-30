using BackendChallengeAPI.Helper;
using BackendChallengeAPI.Models;
using System;
using System.Collections.Generic;

namespace BackendChallengeAPI.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private IEnumerable<Product> _products;

        public ProductBusiness()
        {
            _products = MockedProducts.GetListOfMockedProducts();
        }

        public bool AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetListOfAllProducts()
        {
            return _products;
        }

        public decimal GetProductEstimatedTotalCost(Product product, decimal estimatedConsumption)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsByContractLength(int contractLength)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsByRenewableRating(decimal rate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsByStatus(string status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsBySupplier(string supplier)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
