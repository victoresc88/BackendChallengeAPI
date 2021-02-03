using System.Collections.Generic;
using BackendChallengeAPI.Business;
using BackendChallengeAPI.Exceptions;
using BackendChallengeAPI.Models;
using BackendChallengeAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BackendChallengeAPI.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        public IProductBusiness _productBusiness;

        public ProductController(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;    
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _productBusiness.GetListOfAllProducts();
        }

        [HttpGet("contractLength/{length:int}")]
        public IEnumerable<Product> GetProductsByContractLength(int length)
        {
            try
            {
                return _productBusiness.GetProductsByContractLength(length);
            }
            catch(InvalidProductException ex)
            {
                throw ex;
            }
        }

        [HttpGet("renewableRating/{rate:int}")]
        public IEnumerable<Product> GetProductsByRenewableRating(int rate)
        {
            try
            {
                return _productBusiness.GetProductsByRenewableRating(rate);
            }
            catch (InvalidProductException ex)
            {
                throw ex;
            }
        }

        [HttpGet("status/{status}")]
        public IEnumerable<Product> GetProductsByStatus(string status)
        {
            try
            {
                return _productBusiness.GetProductsByStatus(status);
            }
            catch (InvalidProductException ex)
            {
                throw ex;
            }
        }

        [HttpGet("supplier/{supplier}")]
        public IEnumerable<Product> GetProductsBySupplier(string supplier)
        {
            try
            {
                return _productBusiness.GetProductsBySupplier(supplier);
            }
            catch (InvalidProductException ex)
            {
                throw ex;
            }
        }

        [HttpGet("estimatedTotalCost")]
        public double GetEstimatedTotalCost([FromBody]EstimatedTotalCostViewModel estimatedTotalCostViewModel)
        {
            return _productBusiness.GetProductEstimatedTotalCost(estimatedTotalCostViewModel);
        }

        [HttpPost("add")]
        public bool AddProduct([FromBody]ProductViewModel product)
        {
            try
            {
                return _productBusiness.AddProduct(product);
            }
            catch(InvalidProductException ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        [Route("delete/{id:int}")]
        public bool DeleteProduct(int id)
        {
            try
            {
                return _productBusiness.DeleteProduct(id);
            }
            catch (InvalidProductException ex)
            {
                throw ex;
            }
        }

        [HttpPut("update")]
        public bool UpdateProduct([FromBody]ProductViewModel product)
        {
            try
            {
                return _productBusiness.UpdateProduct(product);
            }
            catch(InvalidProductException ex)
            {
                throw ex;
            }
        }
    }
}
