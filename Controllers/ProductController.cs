using System.Collections.Generic;
using System.Threading.Tasks;
using BackendChallengeAPI.Business;
using BackendChallengeAPI.Models;
using BackendChallengeAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BackendChallengeAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class ProductController : ControllerBase
    {
        public IProductBusiness _productBusiness;

        public ProductController(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;    
        }

        [HttpGet("products")]
        public IEnumerable<Product> GetProducts()
        {
            return _productBusiness.GetListOfAllProducts();
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
