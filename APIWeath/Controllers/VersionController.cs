using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Reflection;
using System.Security.Permissions;

namespace APIWealth.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class VersionController : ControllerBase 
    {
        // [HttpGet]
        // public String Get()
        // {
        //     return "1.5.7";
        // }

        [HttpGet]
        public String GetFromAssemblyInfo()
        {   
            var versionNumber = typeof(VersionController).Assembly.FullName;

            return versionNumber;
        }
    }
    
    [ApiController]
    [Route("[controller]")]
    public class VersionSecondController : ControllerBase 
    {
        [HttpGet]
        public String GetFromAssemblyInfoSecond()
        {   
            Assembly assem = typeof(VersionSecondController).Assembly;
            AssemblyName assemName = assem.GetName();

            var versionNumber = assemName.Version.Major + " " + assemName.Version.Minor;

            return versionNumber;
        }

    }
}