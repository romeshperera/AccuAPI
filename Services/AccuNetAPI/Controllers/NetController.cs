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
            string frm = String.Empty;
            string std = String.Empty;
            string core = String.Empty;
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

            return new string[] { "FramWapper: " + frm, "StdWapper: " + std, "CoreWapper: " + core };
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
