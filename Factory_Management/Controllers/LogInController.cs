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
    public class LogInController : ApiController
    {
        private static readonly LogInBL LogInBL = new LogInBL();
        // GET: api/LogIn
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/LogIn/5
        public bool Get(int id)
        {
            return LogInBL.LoginCheck(id);
        }

        // POST: api/LogIn
        public Users Post(Users user)
        {
            return LogInBL.IsUserExist(user);
        }

        // POST: api/LogIn
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT: api/LogIn/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LogIn/5
        public void Delete(int id)
        {
        }
    }
}
