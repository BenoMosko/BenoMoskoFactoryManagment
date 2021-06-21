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
    public class DepartmentsController : ApiController
    {
        private static readonly DepartmentsBL DepartmentsBL = new DepartmentsBL();
        // GET: api/Departments
        public IEnumerable<Department> Get()
        {
            return DepartmentsBL.GetDepartments();
        }


        public Department Get(int id)
        {
            return DepartmentsBL.GetDepartment(id);
        }

        //// GET: api/Departments/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Departments
        public String Post(Department depart)
        {
            DepartmentsBL.AddDepartment(depart);
            return "Added!";
        }

        // PUT: api/Departments/5
        public String Put(int id,  Department dep)
        {
            DepartmentsBL.EditDepartments(id,  dep);
            return "Updated!";
        }


        // DELETE: api/Departments/5
        public String Delete(int id)
        {
            DepartmentsBL.DeleteDepartment(id);
            return "Deleted!";
        }
    }
}
