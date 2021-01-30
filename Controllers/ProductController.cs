using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BackendChallengeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        public ProductController()
        {
            
        }

        [HttpGet]
        public IEnumerable<int> Get()
        {
            throw new NotImplementedException();
        }
    }
}
