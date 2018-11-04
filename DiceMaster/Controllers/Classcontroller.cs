using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiceMaster.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiceMaster.Controllers
{
    [Route("api/classes")]
    public class ClassController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(new Class[]
            {
                new Class()
                {
                    Name = "Magus"
                },
                new Class()
                {
                    Name = "Barbarian"
                },
                new Class()
                {
                    Name = "Druid"
                }
            });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(new Class()
            {
                Name = "Magus"
            });
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]Class value)
        {
            return BadRequest();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody]Class value)
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
