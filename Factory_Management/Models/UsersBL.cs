using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Management.Models
{
    public class UsersBL
    {
        readonly FaectoryEntities FaectoryDB = new FaectoryEntities();
        public List<Users> GetUsers()
        {
            return FaectoryDB.Users.ToList();
        }
        public Users GetUserByID(int id)
        {
            return FaectoryDB.Users.Where(x => x.ID == id).First();
        }

        public void EditUser(int id, Users user)
        {
            var CurrentUser = FaectoryDB.Users.Where(u => u.ID == id).First();
            //CurrentUser.Full_Name = user.Full_Name;
            //CurrentUser.User_Name = user.User_Name;
            //CurrentUser.Password = user.Password;
            CurrentUser.Number_Of_Actions = user.Number_Of_Actions;
            CurrentUser.Allowed_Actions = user.Allowed_Actions;
            FaectoryDB.SaveChanges();
        }

    }
}