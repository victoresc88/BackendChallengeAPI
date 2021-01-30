using System.Collections.Generic;
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

        [HttpGet]
        [Route("estimatedTotalCost")]
        public double GetEstimatedTotalCost([FromBody]EstimatedTotalCostViewModel estimatedTotalCostViewModel)
        {
            return _productBusiness.GetProductEstimatedTotalCost(estimatedTotalCostViewModel);
        }
    }
}
