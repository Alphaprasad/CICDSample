using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CICDDemo.Models;
namespace CICDDemo.Controllers
{
    public class SampleController : Controller
    {
        [HttpGet("GetText")]
        public String GetDemo()
        {
            return "Hello";
        }
        [HttpGet("health")]
        public String GetHealthCheck()
        {
            return "Health check";
        }

        [HttpGet("GetDeploymentEnvironment")]
        public String GetDeploymentEnvironment()
        {
            return AppDetails.ENV_DeploymentEnvironment;
        }
    }
}
