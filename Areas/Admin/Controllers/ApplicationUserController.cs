using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Treehuggers_WebApp01.Areas.Admin.Models;
using Treehuggers_WebApp01.Models;
using Treehuggers_WebApp01.ViewModel;

/*ApplicationUserController is only authorized for Admin users and controls 
 the rendering and editing of the Applications users table and each user's 
role types. */

namespace Treehuggers_WebApp01.Areas.Admin.Controllers
{
   [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class ApplicationUserController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private RoleManager<IdentityRole> roleManager;
        private treehon1_SQLContext context { get; set; }

        public ApplicationUserController(UserManager<ApplicationUser> userMngr,
            RoleManager<IdentityRole> roleMngr, treehon1_SQLContext ctx)
        {
            userManager = userMngr;
            roleManager = roleMngr;
            context = ctx;
        }


        public async Task<IActionResult> Index()
        {
            List<ApplicationUser> users = new List<ApplicationUser>();
            foreach (ApplicationUser user in userManager.Users)
            {
                user.RoleNames = await userManager.GetRolesAsync(user);
                users.Add(user);
            }
            AppUserViewModel model = new AppUserViewModel
            {
                AppUsers = users,
                Roles = roleManager.Roles
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            ApplicationUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (!result.Succeeded) // if failed
                {
                    string errorMessage = "";
                    foreach (IdentityError error in result.Errors)
                    {
                        errorMessage += error.Description + " | ";
                    }
                    TempData["message"] = errorMessage;
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(RegisterViewModel model)
        {

            if (ModelState.IsValid)
            {
                
                var appuser = new ApplicationUser { UserName = model.Username };
                var result = await userManager.CreateAsync(appuser, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddToAdmin(string id)
        {
            IdentityRole adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole == null)
            {
                TempData["message"] = "Admin role does not exist. "
                    + "Click 'Create Admin Role' button to create it.";
            }
            else
            {

                ApplicationUser user = await userManager.FindByIdAsync(id);

                await userManager.AddToRoleAsync(user, adminRole.Name);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromAdmin(string id)
        {
            ApplicationUser user = await userManager.FindByIdAsync(id);
            var result = await userManager.RemoveFromRoleAsync(user, "Admin");
            if (result.Succeeded) { }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> AddToStaff(string id)
        {
            IdentityRole staffRole = await roleManager.FindByNameAsync("Staff");
            if (staffRole == null)
            {
                TempData["message"] = "Staff role does not exist. "
                    + "Click 'Create Staff Role' button to create it.";
            }
            else
            {
                ApplicationUser user = await userManager.FindByIdAsync(id);
                await userManager.AddToRoleAsync(user, staffRole.Name);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromStaff(string id)
        {
            ApplicationUser user = await userManager.FindByIdAsync(id);
            var result = await userManager.RemoveFromRoleAsync(user, "Staff");
            if (result.Succeeded) { }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> AddToMember(string id)
        {
            IdentityRole memberRole = await roleManager.FindByNameAsync("Member");
            if (memberRole == null)
            {
                TempData["message"] = "Member role does not exist. "
                    + "Click 'Create Member Role' button to create it.";
            }
            else
            {
                ApplicationUser user = await userManager.FindByIdAsync(id);
                await userManager.AddToRoleAsync(user, memberRole.Name);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromMember(string id)
        {
            ApplicationUser user = await userManager.FindByIdAsync(id);
            var result = await userManager.RemoveFromRoleAsync(user, "Member");
            if (result.Succeeded) { }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteRole(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);
            var result = await roleManager.DeleteAsync(role);
            if (result.Succeeded) { }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateAdminRole()
        {
            var result = await roleManager.CreateAsync(new IdentityRole("Admin"));
            if (result.Succeeded) { }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateStaffRole()
        {
            var result = await roleManager.CreateAsync(new IdentityRole("Staff"));
            if (result.Succeeded) { }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateMemberRole()
        {
            var result = await roleManager.CreateAsync(new IdentityRole("Member"));
            if (result.Succeeded) { }
            return RedirectToAction("Index");
        }
    }
}
