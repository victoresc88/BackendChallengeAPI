using System.Collections.Generic;
using System.Threading.Tasks;
using BackendChallengeAPI.Business;
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
            return _productBusiness.GetProductsByContractLength(length);
        }

        [HttpGet("renewableRating/{rate:int}")]
        public IEnumerable<Product> GetProductsByRenewableRating(int rate)
        {
            return _productBusiness.GetProductsByRenewableRating(rate);
        }

        [HttpGet("status/{status}")]
        public IEnumerable<Product> GetProductsByStatus(string status)
        {
            return _productBusiness.GetProductsByStatus(status);
        }

        [HttpGet("supplier/{supplier}")]
        public IEnumerable<Product> GetProductsBySupplier(string supplier)
        {
            return _productBusiness.GetProductsBySupplier(supplier);
        }

        [HttpGet("estimatedTotalCost")]
        public double GetEstimatedTotalCost([FromBody]EstimatedTotalCostViewModel estimatedTotalCostViewModel)
        {
            return _productBusiness.GetProductEstimatedTotalCost(estimatedTotalCostViewModel);
        }

        [HttpPost("add")]
        public bool AddProduct([FromBody]ProductViewModel product)
        {
            return _productBusiness.AddProduct(product);
        }

        [HttpDelete]
        [Route("delete/{id:int}")]
        public bool DeleteProduct(int id)
        {
            return _productBusiness.DeleteProduct(id);
        }

        [HttpPut("update")]
        public bool UpdateProduct([FromBody]ProductViewModel product)
        {
            return _productBusiness.UpdateProduct(product);
        }
        
    }
}
