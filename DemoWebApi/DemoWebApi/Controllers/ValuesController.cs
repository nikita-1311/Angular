using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DemoWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [EnableCors (origins:"http://localhost:4200",headers:"*",methods:"*")]
        public IEnumerable<string> Get()
        {
            List<string> productName = new List<string>();
            productName.Add("Laptop");
            productName.Add("Mobile");
            productName.Add("Tablets");
            productName.Add("TV");
            return productName;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
