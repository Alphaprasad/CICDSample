using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CICDDemo.Models
{
    public class AppDetails
    {
        public static string ENV_DBConnectionString { get; set; }
        public static string ENV_DeploymentEnvironment { get; set; } = "Default";
    }
}
