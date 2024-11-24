using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quizz1.Models
{
    public class UserList
    {
        public static List<User> UsersList = new List<User>()
        {
            new User
            { Id = 0,
              Name = "admin",
              Email = "admin@gmail.com",
              Password = "123123123",
              isFirstLogin = true,
            },
            new User
            { Id = 1,
              Name = "Toko",
              Email = "toko@gmail.com",
              Password = "toko1212",
              isFirstLogin = true,
            },
        };
    }
}