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
        // Test method for the blast cannon
        [HttpGet]
        public string Get()
        {
            return Blast(new EnemyCoordinates());
        }
        
        // Hit the specified point relative to the cannon center
        [HttpPost]
        public string Post([FromBody] EnemyCoordinates coordinates)
        {
            return Blast(coordinates);
        }

        private string Blast(EnemyCoordinates coordinates)
        {    
            var httpConnectionFeature = HttpContext.Features.Get<IHttpConnectionFeature>();
            var localIpAddress = httpConnectionFeature?.LocalIpAddress;
            
            bool hit = coordinates.X > 0.1 && coordinates.Y > 0.1;
            string hitMessage = hit?"HIT":"MISS";
            string message = $"Bang[{coordinates.X}/{coordinates.Y}] = {hitMessage} | {localIpAddress} @ {DateTime.Now.ToString()}";

            Console.WriteLine(message);

            return message;
        }
    }
}
