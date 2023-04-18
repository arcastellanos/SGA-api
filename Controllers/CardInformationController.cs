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
    public class CardInformationController : ControllerBase
    {
        // GET: api/CardInformation
        [EnableCors("OpenPolicy")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // // GET: api/CardInformation/5
        // [EnableCors("OpenPolicy")]
        // [HttpGet("{id}", Name = "Get")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // POST: api/CardInformation
        [EnableCors("OpenPolicy")]
        [HttpPost]
        public void Post([FromBody] CardInformation myCardInfo)
        {
            System.Console.WriteLine("am i here");
            ISaveCardInformation postObject = new SaveCardInformation();
            postObject.PostCardInformation(myCardInfo);

        }

        // PUT: api/CardInformation/5
        [EnableCors("OpenPolicy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/CardInformation/5
        [EnableCors("OpenPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
