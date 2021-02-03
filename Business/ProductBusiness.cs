using BackendChallengeAPI.Exceptions;
using BackendChallengeAPI.Helper;
using BackendChallengeAPI.Models;
using BackendChallengeAPI.ViewModels;
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
                ExceptionHandler.ValidateProduct(product);

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
            ExceptionHandler.ValidateId(id);

            return _products.RemoveAll(p => p.Id == id) > 0;
        }

        public List<Product> GetListOfAllProducts()
        {
            return _products;
        }

        public double GetProductEstimatedTotalCost(EstimatedTotalCostViewModel estimatedTotalCostViewModel)
        {
            try
            {
                const int DAYS_OF_YEAR = 365;
                const int PERIOD = 12;

                ExceptionHandler.ValidateId(estimatedTotalCostViewModel.Id);

                if (_products.Any(p => p.Id == estimatedTotalCostViewModel.Id))
                {
                    var product = _products
                    .Where(p => p.Id == estimatedTotalCostViewModel.Id)
                    .First();

                    return (product.DailyStandingCharge * DAYS_OF_YEAR + estimatedTotalCostViewModel.EstimatedConsumption * product.Rate) * product.ContractLength / PERIOD;
                }
                else
                    throw new InvalidProductException("Product not found");
                
            }
            catch (InvalidProductException ex)
            {
                throw ex;
            }
        }

        public List<Product> GetProductsByContractLength(int length)
        {
            try
            {
                ExceptionHandler.ValidateContractLength(length);

                return _products
                .Where(p => p.ContractLength == length)
                .ToList();
            }
            catch (InvalidProductException ex)
            {
                throw ex;
            }
        }

        public List<Product> GetProductsByRenewableRating(double rate)
        {
            try
            {
                ExceptionHandler.ValidateRate(rate);

                return _products
                .Where(p => p.Renewable == rate)
                .ToList();
            }
            catch (InvalidProductException ex)
            {
                throw ex;
            }
        }

        public List<Product> GetProductsByStatus(string status)
        {
            try
            {
                ExceptionHandler.ValidateStatus(status);

                return _products
                .Where(p => p.Status == status)
                .ToList();
            }
            catch (InvalidProductException ex)
            {
                throw ex;
            }
        }

        public List<Product> GetProductsBySupplier(string supplier)
        {
            try
            {
                ExceptionHandler.ValidateSupplier(supplier);

                return _products
                .Where(p => p.Supplier == supplier)
                .ToList();
            }
            catch (InvalidProductException ex)
            {
                throw ex;
            }
        }

        public bool UpdateProduct(ProductViewModel productViewModel)
        {
            try
            {
                ExceptionHandler.ValidateProduct(productViewModel);

                /* Typically would use Automapper to reduces lines of code, 
                but for the purpose of the exercise thought this would be fine */
                if (_products.ToList().Any(p => p.Id == productViewModel.Id))
                {
                    _products.RemoveAll(p => p.Id == productViewModel.Id);

                    _products.Add(new Product
                    {
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
                else
                    throw new InvalidProductException("Product not found");
                
            }
            catch (InvalidProductException ex)
            {
                throw ex;
            }
        }
    }
}
