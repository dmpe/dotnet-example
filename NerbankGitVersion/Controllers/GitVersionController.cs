using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NerbankGitVersion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NerbankGitVersionController : ControllerBase
    {

        [HttpGet]
        public String GetInfo()
        {
            var versionNumber = typeof(NerbankGitVersionController).Assembly.FullName;
            return versionNumber;
        }
    }
}
