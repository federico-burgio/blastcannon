using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace blastcannon.Controllers
{
    [Route("api/[controller]")]
    public class BlastController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            var httpConnectionFeature = HttpContext.Features.Get<IHttpConnectionFeature>();
            var localIpAddress = httpConnectionFeature?.LocalIpAddress;
            Console.WriteLine("Bang!");
            
            return $"Bang!{localIpAddress} @ {DateTime.Now.ToString()}";
        }
        
        // GET api/values
        [HttpPost]
        public string Post([FromBody] EnemyCoordinates coordinates)
        {
            var httpConnectionFeature = HttpContext.Features.Get<IHttpConnectionFeature>();
            var localIpAddress = httpConnectionFeature?.LocalIpAddress;
            
            Console.WriteLine("Bang!");

            return $"Bang -> {coordinates.X}/{coordinates.Y}! {localIpAddress} @  {DateTime.Now.ToString()}";
        }
    }
}
