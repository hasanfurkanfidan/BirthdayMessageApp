using Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.SeedData
{
    public class SeedDatabase
    {
        public static void SeedUser(UserManager<AppUser> userManager)
        {
            if (userManager.FindByEmailAsync("gtukar@gmail.com").Result == null)
            {
                AppUser user = new AppUser();
                user.UserName = "furkanfidan.job@gmail.com";
                user.Email = "furkanfidan.job@gmail.com";
                user.BirthDate = DateTime.Now;
                IdentityResult result = userManager.CreateAsync
                (user, "Zt9WQUdx").Result;                
            }
        }
    }
}
