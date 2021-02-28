using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PrimeNumbers.Controllers
{
    [ApiController]
    [Route("")]
    public class StatusController : Controller
    {
        private const string V = "Name Program: Prime Numbers (Homework 10) | Author: Halych Ivan";

        [HttpGet]
        public ActionResult<string> Index()
        {
            return V;
        }
    }
}
