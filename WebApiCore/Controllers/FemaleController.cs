﻿using System;
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
        private IProduto _produto;

        public FemaleController(ICatalogo catalogo, IProduto produto)
        {
            _catalogo = catalogo;
            _produto = produto;
        }

        // GET: api/Female
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string[] catalog = _catalogo.RetornaCatalogo();
            return new string[] { "Prada T-shirt", "Supreme Skirt", "Diesel Jeans" }.Concat(catalog);
        }

        // GET: api/Female/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return _produto.RetornaProduto(id);
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
