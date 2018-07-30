using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCore.Controllers
{
    [Produces("application/json")]
    [Route("api/Female")]
    public class FemaleController : Controller
    {

        private ICatalogo _catalogo;

        public FemaleController(ICatalogo catalogo)
        {
            _catalogo = catalogo;
        }

        // GET: api/Female
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string[] catalog = _catalogo.RetornaCatalogo().Split(',');
            return new string[] { "Prada T-shirt", "Supreme Skirt" }.Concat(catalog);
        }

        // GET: api/Female/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Female
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Female/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
