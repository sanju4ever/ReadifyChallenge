using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Readify.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Fibonacci")]
    public class FibonacciController : Controller
    {
        [HttpGet]
        public IActionResult Get(long n)
        {
            if (n <= 0) return NoContent();

            try
            {
                return Ok(Convert.ToString(n));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
        }
    }
}