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
            try
            {
                if (n < 0 || n > 92) return NoContent();

                var result = CalculateFibonacci(n);
                return Ok(result);
            }
            catch
            {
                return BadRequest("The request is invalid.");
            }
        }

        private long CalculateFibonacci(long n)
        {
            long fn = 1;
            long fn1 = 1;
            long fn2 = 0;

            if (n == 1 || n == 2)
            {
                fn2 = 1;
            }

            for (long i = 3; i <= n; i++)
            {
                fn2 = fn1 + fn;
                fn = fn1;
                fn1 = fn2;
            }

            return fn2;
        }
    }
}