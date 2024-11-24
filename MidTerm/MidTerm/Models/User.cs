using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MidTerm.Models
{
    public class User
    {
        public UserLogin UserLogin { get; set; }

        public UserInfo UserInfo { get; set; }

        public UserContact UserContact { get; set; }
    }
}