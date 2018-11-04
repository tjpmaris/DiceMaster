using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiceMaster.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiceMaster.Controllers
{
    [Route("api/[controller]")]
    public class CharactersController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(new Character[]
            {
                new Character()
                {
                    Name = "Emori",
                    Class = new Class()
                    {
                        Name = "Magus"
                    },
                    Race = new Race()
                    {
                        Name = "Half Elf"
                    }
                },
                new Character()
                {
                    Name = "Rahdos",
                    Class = new Class()
                    {
                        Name = "Barbarian"
                    },
                    Race = new Race()
                    {
                        Name = "Half Orc"
                    }
                },
                new Character()
                {
                    Name = "Willump",
                    Class = new Class()
                    {
                        Name = "Druid"
                    },
                    Race = new Race()
                    {
                        Name = "Dwarf"
                    }
                }
            });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(new Character()
            {
                Name = "Emori",
                Class = new Class()
                {
                    Name = "Magus"
                },
                Race = new Race()
                {
                    Name = "Half Elf"
                }
            });
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]Character value)
        {
            return BadRequest();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody]Character value)
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
