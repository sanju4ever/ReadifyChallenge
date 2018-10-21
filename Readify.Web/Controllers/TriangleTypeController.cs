using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Readify.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/TriangleType")]
    public class TriangleTypeController : Controller
    {
        [HttpGet]
        public IActionResult Get(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0) return BadRequest("The request is invalid.");

            try
            {
                return Ok(DetermineTriangleType(a, b, c));
            }
            catch
            {
                return BadRequest("The request is invalid.");
            }
        }

        private string DetermineTriangleType(int a, int b, int c)
        {
            if (a == b && a == c) return "Equilateral";

            if (a == b || a == c || b == c) return "Isosceles";

            return "Scalene";
        }
    }
}