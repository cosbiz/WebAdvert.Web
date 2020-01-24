using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ValidateToken.Controllers
{
    [ApiController]
    [Route("api")]
    public class ValuesController : ControllerBase
    {
        // Get api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello";
        }
    }
}
