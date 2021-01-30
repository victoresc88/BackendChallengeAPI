using System;
using System.Collections.Generic;
using System.Linq;
using BackendChallengeAPI.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BackendChallengeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        public IProductBusiness _productBusiness;

        public ProductController(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;    
        }

        [HttpGet]
        public IEnumerable<int> Get()
        {
            throw new NotImplementedException();
        }
    }
}
