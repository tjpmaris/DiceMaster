using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiceMaster.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiceMaster.Controllers
{
    [Route("api/[controller]")]
    public class RacesController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(new Race[]
            {
                new Race()
                {
                    Name = "Human"
                },
                new Race()
                {
                    Name = "Dwarf"
                },
                new Race()
                {
                    Name = "Elf"
                }
            });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(new Race()
            {
                Name = "Human"
            });
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]Race value)
        {
            return BadRequest();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody]Race value)
        {
            return BadRequest();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            return BadRequest();
        }
    }
}
