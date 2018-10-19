using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Readify.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/ReverseWords")]
    public class ReverseWordsController : Controller
    {
        [HttpGet]
        public IActionResult Get(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return NoContent();

            try
            {
                return Ok(Convert.ToString(sentence));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
        }
    }
}