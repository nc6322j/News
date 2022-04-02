﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace News.Entities
{
    public class AppUser :IdentityUser
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DoB { set; get; }




        public List<Idea> ideasList { set; get; }
        public List<UserInDepartment> userInDepartmentsList { set; get; }


    }
}
