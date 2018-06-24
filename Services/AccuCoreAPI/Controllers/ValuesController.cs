using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AccuCoreAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string frm = String.Empty;
            string std = String.Empty;
            string core = String.Empty;
            //try
            //{
            //    frm = NetFramWapper.NetFrameWap.Add(1, 2).ToString();
            //}
            //catch (Exception ex)
            //{ 
            //    frm = "FAILED - " + ex.Message;
            //}

            try
            {
                std = NetStdWapper.NetStdWap.Add(1, 2).ToString();
            }
            catch (Exception ex)
            {
                std = "FAILED - " + ex.Message;
            }

            try
            {
                core = NetCoreWapper.NetCoreWap.Add(1, 2).ToString();
            }
            catch (Exception ex)
            {
                core = "FAILED - " + ex.Message;
            }

            return new string[] { "FramWapper: "+ frm, "XStdWapper: "+ std, "XCoreWapper: " + core };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
