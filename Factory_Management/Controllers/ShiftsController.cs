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
        public IEnumerable<Shift> Get()
        {
            return ShiftsBL.GetShifts();
        }

        // GET: api/Shifts/5
        public Shift Get(int id)
        {
            return ShiftsBL.GetShift(id);
        }

        // POST: api/Shifts
        public string Post(Shift sh)
        {
            ShiftsBL.AddShift(sh);
            return "Shift Added!";
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
