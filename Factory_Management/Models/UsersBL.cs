using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Management.Models
{
    public class UsersBL
    {
        FaectoryEntities FaectoryDB = new FaectoryEntities();
        public List<Users> GetUsers()
        {
            return FaectoryDB.Users.ToList();
        }
        public Users GetUserByID(int id)
        {
            return (Users)FaectoryDB.Users.Where(x => x.ID == id).First();
        }
    }
}