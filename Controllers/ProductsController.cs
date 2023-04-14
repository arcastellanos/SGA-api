using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGA_api.Models;
using SGA_api.Database;
using SGA_api.Interface;
using Microsoft.AspNetCore.Cors;

namespace SGA_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/Products
        [EnableCors("OpenPolicy")]
        [HttpGet]
        public List<Product> Get()
        {   
            IReadData myProducts = new ReadProducts();
            return myProducts.GetAllProducts();
        }
    
        // GET: api/Products/5
        // [EnableCors("OpenPolicy")]
        // [HttpGet("{id}", Name = "Get")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // POST: api/Products
        [EnableCors("OpenPolicy")]
        [HttpPost]
        public void Post([FromBody] Product myProduct)
        {
            //There is currently a 500 error but the database does update so it should be fine once the frontend works.
            ISaveProducts postObject = new SaveProducts();
            postObject.PostProduct(myProduct);
        }

        // PUT: api/Products/5
        [EnableCors("OpenPolicy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product myProduct)
        {
            IUpdateProducts putObject = new UpdateProducts();
            putObject.UpdateProduct(id, myProduct);
        }

        // DELETE: api/Products/5
        [EnableCors("OpenPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
