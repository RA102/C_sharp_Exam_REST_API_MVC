using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace WebApplication4.Models
{
    public class AppDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {

        protected override void Seed(ApplicationDbContext context)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            var roleAdmin = new IdentityRole { Name = "admin" };
            var roleCoach = new IdentityRole { Name = "coach" };
            var rolePeople = new IdentityRole { Name = "people" };

            //roleManager.Create(roleAdmin);
            //roleManager.Create(roleCoach);
            //roleManager.Create(rolePeople);

            Roles.CreateRole("admin");


            Roles.AddUserToRole("admin@mail.loc", "admin");

            base.Seed(context);
        }
    }
}