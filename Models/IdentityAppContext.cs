using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Treehuggers_WebApp01.Models.Configuration;
using Treehuggers_WebApp01.Models;

/* IdentityAppContext - the context class which configures the Identity 
 tables for the application and sets up everyting to be created in the database
 and used in the application. It extends IdentityDbContext on the ApplicationUser class*/

namespace Treehuggers_WebApp01.Models
{
    public class IdentityAppContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityAppContext(DbContextOptions<IdentityAppContext> options)
            : base(options)
        { }

        /* The modelbuilder method applies the RoleConfiguration that we created 
         * inside the /Models/Configuration/RoleConfiguration file. */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }

        /* The three Roles that are created for the applicaiton are Member, Staff, and Admin.
         These three methods create the Admin, Staff, and Member users that are always going to
         be on the web application and are always checked for. */
        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {

            UserManager<ApplicationUser> userManager =
                serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            RoleManager<IdentityRole> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            // Professor Sander's Admin Profile
            string username1 = "admin@cpt275.beausanders.org";
            string password1 = "teamProjeck275";

            string username = "treehon1_Admin";
            string password = "Treehon1";
            string email = "treehon1admin@gmail.com";
            string firstname = "treehon1";
            string lastname = "Admin";

            string roleName = "Admin";

            // if role doesn't exist, create it
            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            // if username doesn't exist, create it and add to role
            if (await userManager.FindByNameAsync(username) == null)
            {
               
                ApplicationUser user = new ApplicationUser 
                { 
                    UserName = username,
                    Email = email,
                    FirstName = firstname,
                    LastName = lastname
                
                };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }

            if (await userManager.FindByNameAsync(username1) == null)
            {
               

                ApplicationUser user = new ApplicationUser
                {
                    UserName = username1,
                    Email = "admin@cpt275.beausanders.org",
                    FirstName = "Beau",
                    LastName = "Sanders"
                };
                var result = await userManager.CreateAsync(user, password1);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }

        public static async Task CreateStaffUser(IServiceProvider serviceProvider)
        {

            UserManager<ApplicationUser> userManager =
                serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            RoleManager<IdentityRole> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string username = "treehon1_Staff";
            string password = "Treehon1";
            string email = "treehon1staff@gmail.com";
            string firstname = "treehon1";
            string lastname = "Staff";

            string roleName = "Staff";

            // if role doesn't exist, create it
            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            // if username doesn't exist, create it and add to role
            if (await userManager.FindByNameAsync(username) == null)
            {
               

                ApplicationUser user = new ApplicationUser 
                { 
                    UserName = username,
                    Email = email,
                    FirstName = firstname,
                    LastName = lastname
                };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }

        public static async Task CreateMemberUser(IServiceProvider serviceProvider)
        {

            UserManager<ApplicationUser> userManager =
                serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            RoleManager<IdentityRole> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string username = "treehon1_Member";
            string password = "Treehon1";
            string email = "treehon1member@gmail.com";
            string firstname = "treehon1";
            string lastname = "Member";

            string roleName = "Member";

            // if role doesn't exist, create it
            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            // if username doesn't exist, create it and add to role
            if (await userManager.FindByNameAsync(username) == null)
            {
                
                ApplicationUser user = new ApplicationUser
                {
                    UserName = username,
                    Email = email,
                    FirstName = firstname,
                    LastName = lastname
                };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }
    }
}
