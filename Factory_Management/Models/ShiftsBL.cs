using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Management.Models
{
    public class ShiftsBL
    {
        readonly FaectoryEntities FactoryDB = new FaectoryEntities();

        public List<Shift> GetShifts()
        {
            return FactoryDB.Shift.ToList();
        }
        public Shift GetShift(int id)
        {
            return FactoryDB.Shift.Where(s => s.ID == id).First();
        }
        public void AddShift(Shift sh)
        {
            FactoryDB.Shift.Add(sh);
            FactoryDB.SaveChanges();
        }
    }
}