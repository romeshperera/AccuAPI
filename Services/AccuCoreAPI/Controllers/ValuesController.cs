using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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
            string host = String.Empty;
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

            try
            {
                host = Dns.GetHostName() + " - ";
                IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
                foreach (IPAddress addr in localIPs)
                {
                    if (addr.AddressFamily == AddressFamily.InterNetwork)
                    {
                        host = addr + " : ";
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return new string[] { "FramWapper: "+ frm, "XStdWapper: "+ std, "XCoreWapper: " + core, "Host: " + host };
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
