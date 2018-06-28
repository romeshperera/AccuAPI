using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Web.Http;

namespace AccuNetAPI.Controllers
{
    public class NetController : ApiController
    {
        // GET: api/Net
        public IEnumerable<string> Get()
        {
            string frm = String.Empty;
            string std = String.Empty;
            string core = String.Empty;
            string host = String.Empty;
            try
            {
                frm = NetFramWapper.NetFrameWap.Add(1, 2).ToString();
            }
            catch (Exception ex)
            {
                frm = "FAILED - " + ex.Message;
            }

            try
            {
                std = NetStdWapper.NetStdWap.Add(1, 2).ToString();
            }
            catch (Exception ex)
            {
                std = "FAILED - " + ex.Message;
            }

            //try
            //{
            //    core = NetCoreWapper.NetCoreWap.Add(1, 2).ToString();
            //}
            //catch (Exception ex)
            //{
            //    core = "FAILED - " + ex.Message;
            //}

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

            return new string[] { "FramWapper: " + frm, "StdWapper: " + std, "CoreWapper: " + core, "Host: " + host };
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
