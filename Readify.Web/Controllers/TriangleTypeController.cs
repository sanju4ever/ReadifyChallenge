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
            if (a <= 0 || b <= 0 || c <= 0) return NoContent();

            try
            {
                return Ok(Convert.ToString(a + b + c));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
        }
    }
}