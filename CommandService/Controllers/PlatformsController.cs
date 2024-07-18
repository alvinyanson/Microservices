using Microsoft.AspNetCore.Mvc;
using System;

namespace CommandService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {
            
        }

        [HttpPost]
        public ActionResult TestInBoundConnection()
        {
            Console.WriteLine("Inbound POST # Command Service");

            return Ok("Inbound test of from Platforms Controller");
        }
    }
}
