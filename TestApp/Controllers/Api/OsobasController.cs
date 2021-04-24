using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApp.Models;

namespace TestApp.Controllers.Api
{
    public class OsobasController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Osoba> Get()
        {
            return new List<Osoba> { new Osoba() { Ime = "a" }, new Osoba() { Ime = "b" } };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}