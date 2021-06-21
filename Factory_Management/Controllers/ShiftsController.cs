using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Factory_Management.Models;

namespace Factory_Management.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ShiftsController : ApiController
    {
        private static readonly ShiftsBL ShiftsBL = new ShiftsBL();
        // GET: api/Shifts
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Shifts/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Shifts
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Shifts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Shifts/5
        public void Delete(int id)
        {
        }
    }
}
