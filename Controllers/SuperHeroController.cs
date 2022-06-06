using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SuperHero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var heroes = new List<SuperHero>
            {
                new SuperHero {
                    Id = 1,
                    Name = "Spider Man",
                    FirstName="Peter",
                    LastName="Parker",
                    Place="New York City"
                }
             };
            return NotFound(heroes);
        }
    }
}
