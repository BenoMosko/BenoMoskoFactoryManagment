using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Management.Models
{
    public class LogInBL
    {
        FaectoryEntities FaectoryDB = new FaectoryEntities();
        private static LogsCheck log = new LogsCheck();

        //public bool IsUserExist(string username, string password)
        //{
        //    var result = FaectoryDB.Users.Where(x => x.User_Name == username && x.Password == password);
        //    if (result.Count() > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public List<Users> GetUsers()
        {
            return FaectoryDB.Users.ToList();
        }
        public Users GetUserByID(int id)
        {
            return FaectoryDB.Users.Where(x => x.ID == id).First();
        }

        public Users IsUserExist(Users user)
        {
            var result = FaectoryDB.Users.Where(un => un.User_Name == user.User_Name && un.Password == user.Password);
            var res = result.First();

            if (result.Count() == 1)
            {
                DateTime DateTimeNow = DateTime.Now;

                var CheckLog = FaectoryDB.Logins.Where(log => log.UserID == res.ID);

                if (CheckLog.Count() == 1)
                {
                    if (CheckLog.FirstOrDefault().Date.ToShortDateString() != DateTimeNow.ToShortDateString())
                    {
                        CheckLog.FirstOrDefault().Actions = 0;
                        FaectoryDB.SaveChanges();
                    }
                }
                else
                {
                    Logins NewLogIn = new Logins
                    {
                        UserID = res.ID,
                        Date = DateTimeNow
                    };
                    FaectoryDB.Logins.Add(NewLogIn);
                    FaectoryDB.SaveChanges();
                }
                return res;
            }
            else
            {
                return null;
            }
        }

        public bool LoginCheck(int id)
        {
            return log.CheckLogs(id);
        }
    }
}