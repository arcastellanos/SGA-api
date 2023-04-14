using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using SGA_api.Models;
using SGA_api.Database;
using SGA_api.Interface;

namespace SGA_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PickupController : ControllerBase
    {
        // GET: api/Pickup
        [EnableCors("OpenPolicy")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // // GET: api/Pickup/5
        // [EnableCors("OpenPolicy")]
        // [HttpGet("{id}", Name = "Get")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // POST: api/Pickup
        [EnableCors("OpenPolicy")]
        [HttpPost]
        public void Post([FromBody] Pickup myPickup)
        {
            ISavePickup postObject = new SavePickup();
            postObject.PostPickup(myPickup);
        }

        // PUT: api/Pickup/5
        [EnableCors("OpenPolicy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Pickup/5
        [EnableCors("OpenPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
