using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Management.Models
{
    public class DepartmentsBL
    {
        readonly FaectoryEntities FactoryDB = new FaectoryEntities();

        public List<Department> GetDepartments()
        {
            return FactoryDB.Department.ToList();
        }

        public Department GetDepartment(int id)
        {
            return FactoryDB.Department.Where(d => d.ID == id).First();
        }

        public void EditDepartments(int id, Department dep)
        {
            var currentDepartment = FactoryDB.Department.Where(d => d.ID == id).First();
            currentDepartment.Name = dep.Name;
            currentDepartment.Manager = dep.Manager;
            FactoryDB.SaveChanges();
        }

        public void DeleteDepartment(int id)
        {
            var currentDepartment = FactoryDB.Department.Where(d => d.ID == id).First();
            FactoryDB.Department.Remove(currentDepartment);
            FactoryDB.SaveChanges();
        }

        public void AddDepartment(Department depart)
        {
            FactoryDB.Department.Add(depart);
            FactoryDB.SaveChanges();
        }
    }

}