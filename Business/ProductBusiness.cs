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
        private List<Product> _products;

        public ProductBusiness()
        {
            _products = MockedProducts.GetListOfMockedProducts();
        }

        public bool AddProduct(ProductViewModel product)
        {
            /* Typically would use Automapper to reduces lines of code, 
            but for the purpose of the exercise thought this would be fine */
            _products.Add(new Product {
                Id = product.Id,
                Name = product.Name,
                Status = product.Status,
                Rate = product.Rate,
                Renewable = product.Renewable,
                ContractLength = product.ContractLength,
                DailyStandingCharge = product.DailyStandingCharge,
                Supplier = product.Supplier
            });

            return _products.Any(p => p.Id == product.Id);
        }

        public bool DeleteProduct(int id)
        {
            return _products.RemoveAll(p => p.Id == id) == 1;
        }

        public List<Product> GetListOfAllProducts()
        {
            return _products;
        }

        public double GetProductEstimatedTotalCost(EstimatedTotalCostViewModel estimatedTotalCostViewModel)
        {
            var product = _products
                .Where(p => p.Id == estimatedTotalCostViewModel.Id)
                .First();

            return (product.DailyStandingCharge * 365 + estimatedTotalCostViewModel.EstimatedConsumption * product.Rate) 
                * product.ContractLength 
                / 12;
        }

        public List<Product> GetProductsByContractLength(int contractLength)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByRenewableRating(double rate)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByStatus(string status)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsBySupplier(string supplier)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(ProductViewModel productViewModel)
        {
            /* Typically would use Automapper to reduces lines of code, 
            but for the purpose of the exercise thought this would be fine */
            _products.RemoveAll(p => p.Id == productViewModel.Id);

            _products.Add(new Product {
                Id = productViewModel.Id,
                Name = productViewModel.Name,
                Status = productViewModel.Status,
                Rate = productViewModel.Rate,
                Renewable = productViewModel.Renewable,
                ContractLength = productViewModel.ContractLength,
                DailyStandingCharge = productViewModel.DailyStandingCharge,
                Supplier = productViewModel.Supplier
            });

            return _products.ToList()
                .Any(p => p.Id == productViewModel.Id);
        }
    }
}
