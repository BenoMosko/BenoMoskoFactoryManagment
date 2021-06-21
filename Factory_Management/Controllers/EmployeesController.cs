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
    public class EmployeesController : ApiController
    {
        private static readonly EmployeesBL EmployeesBL = new EmployeesBL();
        // GET: api/Employees
        public IEnumerable<EmployeeDepartmentsShifts> Get()
        {
            return EmployeesBL.GetEmployees();
        }

        // GET: api/Employees/5
        public IEnumerable<EmployeeDepartmentsShifts> Get(int id)
        {
            yield return EmployeesBL.GetEmployee(id);
        }

        //// GET: api/Employees/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Employees
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Employees/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Employees/5
        //public void Delete(int id)
        //{
        //}
    }
}
