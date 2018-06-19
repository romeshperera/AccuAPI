using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AccuNetAPI.Controllers
{
    public class NetController : ApiController
    {
        // GET: api/Net
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Net/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Net
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Net/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Net/5
        public void Delete(int id)
        {
        }
    }
}
