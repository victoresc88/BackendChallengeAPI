using System.Collections.Generic;
using BackendChallengeAPI.Business;
using BackendChallengeAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendChallengeAPI.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        public IProductBusiness _productBusiness;

        public ProductController(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;    
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productBusiness.GetListOfAllProducts();
        }

        [HttpGet]
        [Route("estimatedTotalCost")]
        public double GetEstimatedTotalCost(Product product, double estimatedConsumption)
        {
            return _productBusiness.GetProductEstimatedTotalCost(product, estimatedConsumption);
        }
    }
}
