using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GuggenheimTakeHome.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        public ValuesController()
        {

        }

        [HttpGet]
        public void Get()
        {

        }

        [HttpPost]
        public void Post(string dats)
        {
            var a = Request.Form["minsAbove6"];
            var b = Request.Form["milesBelow6"];
            var c = Request.Form["date"];
            var d = Request.Form["starttime"];
        }
    }
}
