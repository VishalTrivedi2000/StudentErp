using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMNEVH.Models.UserEntities
{
    public class User
    {
        public string userId { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string userMobileNumber { get; set; }
        public string userPassword { get; set; }
        public string UserType { get;  set; }
    }
}