using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiceMaster.Models;
using DiceMaster.Services;
using Microsoft.AspNetCore.Mvc;

namespace DiceMaster.Controllers
{
    [Route("api/characters")]
    public class CharacterController : Controller
    {
        private ICharacterService characterService;
        
        public CharacterController(ICharacterService characterService)
        {
            this.characterService = characterService;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await characterService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(string id)
        {
            return Ok(await characterService.Get(id));
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]Character value)
        {
            var obj = await characterService.Create(value);
            var uri = $"/api/characters/{obj.Id}";

            return Created(uri, await characterService.Create(value));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromBody]Character value)
        {
            return Ok(await characterService.Update(value));       
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            return Ok(await characterService.Delete(id));       
        }
    }
}
