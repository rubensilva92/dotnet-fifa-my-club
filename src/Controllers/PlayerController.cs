using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using fifa_myclub.Models;


namespace fifa_myclub.Controllers
{
    [ApiController]
    [Route("api/v1/players")]
    public class PlayerController : ControllerBase
    {
        [HttpGet("id:int")]
        public Player GetPlayer(int id) {
            Player myPlayer = new Player(
                id,
                "Messi",
                78,
                82,
                72,
                79,
                47,
                75
            );
        return myPlayer;
            
        }
    }
}