using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Interfaces;
using WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VilleController : ControllerBase
    {
        private readonly IUnitofwork uow;
        private readonly DataContext dc;

        // GET: api/<VilleController>

        public VilleController(IUnitofwork uow, DataContext dc )
        {
            this.uow = uow;
            this.dc = dc;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VilleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VilleController>
        [HttpPost]
        public async Task<IActionResult> AddVille (Ville _ville)
        {
            var ville = new Ville
            {
                NomVille = _ville.NomVille,
              
            };
            
            await uow.SaveAsync();
            return StatusCode(201);
        }
    

        // PUT api/<VilleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VilleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
