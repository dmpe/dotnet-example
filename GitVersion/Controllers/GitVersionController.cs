using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GitVersion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitToolsGitVersionController : ControllerBase
    {

        [HttpGet]
        public String GetInfo()
        {
            var versionNumber = typeof(GitToolsGitVersionController).Assembly.FullName;
            return versionNumber;
        }
    }
}
