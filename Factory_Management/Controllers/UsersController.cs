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
    public class UsersController : ApiController
    {
        private static UsersBL UsersBL = new UsersBL();
        // GET: api/Users
        public IEnumerable<Users> Get()
        {
            return UsersBL.GetUsers();
        }

        // GET: api/Users/5
        public Users Get(int id)
        {
            return UsersBL.GetUserByID(id);
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
