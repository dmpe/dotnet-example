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
            // ThisAssembly tc = new ThisAssembly();
            var versionNumber = ThisAssembly.GitCommitId;
            return versionNumber;
        }
    }
}
