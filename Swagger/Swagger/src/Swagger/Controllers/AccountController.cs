﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Swagger.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> GetAccountNames()
        {
            return new string[] { "Salesboost", "Benchmark", "BestWestern","Clubcorp" };
        }
    }
}
