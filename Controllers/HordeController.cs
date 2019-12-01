using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Openshift_tut.Controllers
{
    public class HordeController : Controller
    {
        private static Dictionary<string, string> _cats = new Dictionary<string, string>();

        [HttpGet("horde/add/{cat}")]
        public string Add(string cat, string sound)
        {
            _cats[cat] = sound;

            return $"{cat} added to horde!";
        }

        [HttpGet("horde/{cat}")]
        public string Get(string cat)
        {
            return _cats.ContainsKey(cat) ? _cats[cat] : "Cat not found.";
        }
    }
}