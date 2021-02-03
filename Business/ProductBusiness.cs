using BackendChallengeAPI.Exceptions;
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
            // Get mocked data
            _products = MockedProducts.GetListOfMockedProducts();
        }

        public bool AddProduct(ProductViewModel product)
        {
            try
            {
                /* Typically would use Automapper to reduce lines of code, 
                but for the purpose of the exercise thought this would be fine */
                _products.Add(new Product
                {
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
            catch (InvalidProductException ex)
            {
                throw ex;
            }
        }

        public bool DeleteProduct(int id)
        {
            return _products.RemoveAll(p => p.Id == id) > 0;
        }

        public List<Product> GetListOfAllProducts()
        {
            return _products;
        }

        public double GetProductEstimatedTotalCost(EstimatedTotalCostViewModel estimatedTotalCostViewModel)
        {
            const int DAYS_OF_YEAR = 365;
            const int PERIOD = 12;

            var product = _products
                .Where(p => p.Id == estimatedTotalCostViewModel.Id)
                .First();

            return (product.DailyStandingCharge * DAYS_OF_YEAR + estimatedTotalCostViewModel.EstimatedConsumption * product.Rate) 
                * product.ContractLength 
                / PERIOD;
        }

        public List<Product> GetProductsByContractLength(int length)
        {
            return _products
                .Where(p => p.ContractLength == length)
                .ToList();
        }

        public List<Product> GetProductsByRenewableRating(double rate)
        {
            return _products
                .Where(p => p.Renewable == rate)
                .ToList();
        }

        public List<Product> GetProductsByStatus(string status)
        {
            return _products
                .Where(p => p.Status == status)
                .ToList();
        }

        public List<Product> GetProductsBySupplier(string supplier)
        {
            return _products
                .Where(p => p.Supplier == supplier)
                .ToList();
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
