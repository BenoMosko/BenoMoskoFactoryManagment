using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Management.Models
{
    public class EmployeesBL
    {
        readonly FaectoryEntities FactoryDB = new FaectoryEntities();

        public List<EmployeeDepartmentsShifts> GetEmployees()
        {
            var result = from emp in FactoryDB.Employee
                         join dep in FactoryDB.Department on emp.DepartmentID equals dep.ID
                         join empshift in FactoryDB.EmployeeShift on emp.ID equals empshift.EmployeeID
                         join shift in FactoryDB.Shift on empshift.ShiftID equals shift.ID
                         select new EmployeeDepartmentsShifts
                         {
                             ID = emp.ID,
                             EmployeeID = empshift.EmployeeID,
                             First_Name = emp.First_Name,
                             Last_Name = emp.Last_Name,
                             Start_Work_Year = emp.Start_Work_Year,
                             DepartmentID = dep.ID,
                             Name = dep.Name,
                             ShiftID = shift.ID,
                             Date = shift.Date,
                             Start_Time = shift.Start_Time,
                             End_Time = shift.End_Time

                         };
            return result.ToList();
        }

        public List<EmployeeDepartmentsShifts> GetEmployee(int id)
        {
            var result = (from emp in FactoryDB.Employee
                         join dep in FactoryDB.Department on emp.DepartmentID equals dep.ID
                         join empshift in FactoryDB.EmployeeShift on emp.ID equals empshift.EmployeeID
                         join shift in FactoryDB.Shift on empshift.ShiftID equals shift.ID
                         select new EmployeeDepartmentsShifts
                         {
                             ID = emp.ID,
                             EmployeeID = empshift.EmployeeID,
                             First_Name = emp.First_Name,
                             Last_Name = emp.Last_Name,
                             Start_Work_Year = emp.Start_Work_Year,
                             DepartmentID = dep.ID,
                             Name = dep.Name,
                             ShiftID = shift.ID,
                             Date = shift.Date,
                             Start_Time = shift.Start_Time,
                             End_Time = shift.End_Time

                         }).Where(x => x.ID == id);
            return result.ToList();
        }

        public void  EditEmployee(int id, EmployeeDepartmentsShifts emp)
        {
            var CurrentEmployee = FactoryDB.Employee.Where(e => e.ID == id).First();
            CurrentEmployee.First_Name = emp.First_Name;
            CurrentEmployee.Last_Name = emp.Last_Name;
            CurrentEmployee.Start_Work_Year = emp.Start_Work_Year;
            FactoryDB.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var currentEmployee = FactoryDB.Employee.Where(e => e.ID == id).First();
            FactoryDB.Employee.Remove(currentEmployee);
            FactoryDB.SaveChanges();
        }

        public void AddEmployee(Employee emp)
        {
            FactoryDB.Employee.Add(emp);
            FactoryDB.SaveChanges();
        }
    }
}