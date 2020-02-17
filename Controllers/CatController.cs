using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Openshift_tut.Controllers
{
    public class CatController : Controller
    {
        [HttpGet("cat/{cat}")]
        public string Cat(string cat)
        {
            switch (cat)
            {
                case "bill":
                    return "Meaaww..."
                case "steve":
                    return "Hisss...";
                default:
                    return "Unknown cat....";
            }
        }
    }
}