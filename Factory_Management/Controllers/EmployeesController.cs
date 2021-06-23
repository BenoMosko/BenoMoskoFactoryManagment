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

        public IEnumerable<EmployeeDepartmentsShifts> Get()
        {
            return EmployeesBL.GetEmployees();
        }

        public IEnumerable<EmployeeDepartmentsShifts> Get(int id)
        {
            return EmployeesBL.GetEmployee(id);
        }

        public string Put(int id, EmployeeDepartmentsShifts emp)
        {
            EmployeesBL.EditEmployee(id, emp);
            return "Updated!";
        }

        public String Delete(int id)
        {
            EmployeesBL.DeleteEmployee(id);
            return "Deleted!";
        }

        public String Post(Employee emp)
        {
            EmployeesBL.AddEmployee(emp);
            return "Added!";
        }
    }
}
