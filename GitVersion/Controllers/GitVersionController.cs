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
    
    // [ApiController]
    // [Route("[controller]")]
    // public class GitToolsGitVersionControllerSecond : ControllerBase
    // {
    //     [HttpGet]
    //     public Object GetInfoSecond()
    //     {
    //         var assemblyName = typeof(GitToolsGitVersionControllerSecond).Assembly.GetName().Name;
    //         var gitVersionInformationType = typeof(GitToolsGitVersionControllerSecond).Assembly.GetType("GitVersionInformation");
    //         var versionField = gitVersionInformationType.GetField("Major");

    //         return versionField.GetValue(null);
    //     }

    // }
}
