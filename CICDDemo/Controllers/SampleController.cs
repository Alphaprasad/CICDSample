using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CICDDemo.Controllers
{
    public class SampleController : Controller
    {
        [HttpGet("GetText")]
        public String GetDemo()
        {
            return "Hello";
        }
    }
}
