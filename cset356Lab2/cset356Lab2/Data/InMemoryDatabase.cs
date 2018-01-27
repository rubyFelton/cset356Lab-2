using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cset356Lab2.Data.Entities;

namespace cset356Lab2.Data
{
    public class InMemoryDatabase
    {
        public static List<Users> Users = new List<Users>();
        public static int Id = 0;

        public static int NextId()
        {
            return Id++;
        }

        public static void DeleteUser(int id)
        {
            var user = Users.Find(u => u.Id == id);
            Users.Remove(user);
        }
    }
}