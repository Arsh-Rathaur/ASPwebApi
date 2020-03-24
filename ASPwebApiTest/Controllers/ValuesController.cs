using BLL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASPwebApiTest.Controllers
{
    public class ValuesController : ApiController
    {
        public ProductsOperationsBLL Products;

        public ValuesController()
        {
            this.Products = new ProductsOperationsBLL();
        }

        // GET api/values
        public string Get()
        {
            var Date = DateTime.UtcNow.ToString("o");
            return Date;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
