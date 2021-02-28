using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrimeNumbers.Controllers
{
    [ApiController]
    [Route("/primes")]
    public class PrimesController : Controller
    {
        [HttpGet("{number}")]
        public ActionResult IsPrimeNumber(int number)
        {
            if (number.IsPrime())
                return StatusCode(200);
            return StatusCode(404,null);
        }

        [HttpGet]
        public IActionResult IsPrimeNumber([FromQuery] string to, [FromQuery] string from)
        {
            if ((to == null) || (from == null) || (!int.TryParse(to, out var _to)) || (!int.TryParse(from, out var _from)))
            {
                return StatusCode(404, "Invalid argument");
            }

            if (_from > _to)
                return StatusCode(200);

            var primes = Enumerable.Range(_from, _to - _from + 1).Where(i => i.IsPrime());
            return Content( string.Join(" ", primes));

        }
    }
}
