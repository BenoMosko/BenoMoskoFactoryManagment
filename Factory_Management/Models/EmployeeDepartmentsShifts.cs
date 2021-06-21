namespace Factory_Management.Models
{
    using System;
    using System.Collections.Generic;

    public partial class EmployeeDepartmentsShifts
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public System.DateTime Start_Work_Year { get; set; }
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public int ShiftID { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan Start_Time { get; set; }
        public System.TimeSpan End_Time { get; set; }
    }
}
