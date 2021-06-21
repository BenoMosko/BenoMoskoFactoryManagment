using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Management.Models
{
    public class LogsCheck
    {
        private static readonly FaectoryEntities FaectoryDB = new FaectoryEntities();

        public bool CheckLogs(int UserID)
        {
            var CurrentUserLog = FaectoryDB.Logins.Where(l => l.UserID == UserID).First();
            var currentUser = FaectoryDB.Users.Where(u => u.ID == UserID).First();
            if (CurrentUserLog.Actions > currentUser.Number_Of_Actions)
            {
                return false;
            }
            return true;
        }

        public void AddActionLog(int UserID)
        {
            var currentUserLog = FaectoryDB.Logins.Where(l => l.UserID == UserID).First();
            var currentUser = FaectoryDB.Users.Where(u => u.ID == UserID).First();
            currentUserLog.Actions++;
            FaectoryDB.SaveChanges();
        }
    }
}