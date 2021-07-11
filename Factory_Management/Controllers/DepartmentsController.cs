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
        public IEnumerable<Department> Get()
        {
            return DepartmentsBL.GetDepartments();
        }


        public Department Get(int id)
        {
            return DepartmentsBL.GetDepartment(id);
        }

        public String Post(Department depart)
        {
            DepartmentsBL.AddDepartment(depart);
            return "Added!";
        }

        public String Put(int id,  Department dep)
        {
            DepartmentsBL.EditDepartments(id, dep);
            return "Updated!";
        }


        public String Delete(int id)
        {
            DepartmentsBL.DeleteDepartment(id);
            return "Deleted!";
        }
    }
}
