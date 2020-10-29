using Business_Tracking.Entities.ORM.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business_Tracking.UI.IdentityInitilazer
{
    public static class IdentityIntilazer
    {
        public static async Task SeedData(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            var adminrole = await roleManager.FindByNameAsync("Admin");

            if (adminrole==null)
            {
                await roleManager.CreateAsync(new AppRole() { Name = "Admin" });
            }

            var memberole = await roleManager.FindByNameAsync("Member");

            if (memberole==null)
            {
                await roleManager.CreateAsync(new AppRole() { Name = "Member" });
            }

            var adminuser = await userManager.FindByNameAsync("Yasin");

            if (adminuser==null)
            {
                AppUser user = new AppUser
                {
                    FirstName="Yasin",
                    LastName="Kalender",
                    Email="ysn@gmail.com",
                    UserName="Yasin"


                };


                await userManager.CreateAsync(user,"1");
                await userManager.AddToRoleAsync(user, "Admin");
            }





        }



    }
}
