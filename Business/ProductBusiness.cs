using BackendChallengeAPI.Helper;
using BackendChallengeAPI.Models;
using BackendChallengeAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

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
            _products.ToList().Add(product);   
            return _products.Any(p => p.Id == product.Id);
        }

        public bool DeleteProduct(int id)
        {
            return _products
                .ToList()
                .Remove(_products
                    .Where(p => p.Id == id).First());
        }

        public IEnumerable<Product> GetListOfAllProducts()
        {
            return _products;
        }

        public double GetProductEstimatedTotalCost(EstimatedTotalCostViewModel estimatedTotalCostViewModel)
        {
            var product = _products
                .Where(p => p.Id == estimatedTotalCostViewModel.Id)
                .FirstOrDefault();

            return (product.DailyStandingCharge * 365 + estimatedTotalCostViewModel.EstimatedConsumption * product.Rate) 
                * product.ContractLength 
                / 12;
        }

        public IEnumerable<Product> GetProductsByContractLength(int contractLength)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsByRenewableRating(double rate)
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
