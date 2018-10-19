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
        public IActionResult Get(string sentence = "")
        {
            // if (string.IsNullOrWhiteSpace(sentence)) return NoContent();

            try
            {
                var result = ReverseSentence(sentence.Trim());
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
        }

        private string ReverseSentence(string sentence)
        {
            //char[] charArray = sentence.ToCharArray();
            //Array.Reverse(charArray);
            //return new string(charArray);

            char[] inputArray = new char[sentence.Length];
            for (int idx = 0; idx < sentence.Length; idx++)
            {
                inputArray[idx] = Convert.ToChar(sentence.Substring(idx, 1));
            }

            char[] outputArray = new char[inputArray.Length];
            int i = 0;
            for (int idx = inputArray.Length - 1; idx >= 0; idx--)
            {
                outputArray[i] = inputArray[idx];
                i++;
            }

            return new string(outputArray);
        }
    }
}