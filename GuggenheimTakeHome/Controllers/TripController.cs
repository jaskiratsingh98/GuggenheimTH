using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GuggenheimTakeHome.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TripController : ControllerBase
    {
        public TripController()
        {

        }

        [HttpGet]
        public void Get()
        {

        }

        [HttpPost]
        public string Post()
        {
            var minsAbove6 = int.Parse(Request.Form["minsAbove6"]);
            var milesBelow6 = int.Parse(Request.Form["milesBelow6"]);
            var date = DateTime.Parse(Request.Form["date"]);
            var startTime = TimeSpan.Parse(Request.Form["starttime"]);

            var dateTime = date + startTime;

            var trip = new Trip(milesBelow6, minsAbove6, dateTime);
            return trip.CalculateCost().ToString("0.00", CultureInfo.InvariantCulture);
        }
    }
}
