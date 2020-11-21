using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace GitVersion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitToolsGitVersionController : ControllerBase
    {

        [HttpGet]
        public String GetInfo()
        {
            // var versionNumber = typeof(GitToolsGitVersionController).Assembly.
            var attr = typeof(GitToolsGitVersionController).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;

            return attr;

        }
    }
    
    // [ApiController]
    // [Route("[controller]")]
    // public class GitToolsGitVersionControllerSecond : ControllerBase
    // {
    //     [HttpGet]
    //     public Object GetInfoSecond()
    //     {
    //         // ThisAssembly tc = new ThisAssembly();
    //         var versionNumber = ThisAssembly.GitCommitId;
    //         return versionNumber;

    //         return versionField.GetValue(null);
    //     }

    // }
}
