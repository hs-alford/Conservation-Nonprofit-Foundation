using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Treehuggers_WebApp01.Models;
using Treehuggers_WebApp01.ViewModel;

/* Seperate controller for each data table which handles rendering the table view, 
 the edit/add view, and the logic of adding and editing each entity*/
namespace Treehuggers_WebApp01.Areas.DataTables.Controllers
{
    [Area("DataTables")]
    [Authorize(Roles = "Admin,Staff")]
    public class UserController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        private treehon1_SQLContext context { get; set; }


        public UserController(UserManager<ApplicationUser> userMngr,
            SignInManager<ApplicationUser> signInMngr, treehon1_SQLContext ctx)
        {
            userManager = userMngr;
            signInManager = signInMngr;
            context = ctx;
        }

        public IActionResult User()
        {
            var table = new treehuggersViewModel
            {
                Users = context.Users.ToList()
            };
            return View(table);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new User());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var user = context.Users.Find(id);
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                if (user.UserID == 0)
                    context.Users.Add(user);
                else
                    context.Users.Update(user);
                context.SaveChanges();
                return RedirectToAction("User", "User");
            }
            else
            {
                ViewBag.Action =
                    (user.UserID == 0) ? "Add" : "Edit";
                return View(user);
            }
        }

        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    username_email = model.Email,
                    Password = "Protected",
                    UserType = "M",
                    Status = "A",
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Street_Address1 = model.Street_Address1,
                    Street_Address2 = model.Street_Address2,
                    City = model.City,
                    State = model.State,
                    Zip = model.Zip,
                    Phone = model.Phone,
                    ContactPrefrence = model.ContactPrefrence,
                    Monthly_Dues = model.Monthly_Dues,
                    Date_Joined = DateTime.Today,
                    SolicitedBy = model.SolicitedBy,
                    Comments = model.Comments
                };
                context.Users.Add(user);
                context.SaveChanges();

                var userIdentity = new ApplicationUser
                {
                    UserName = model.Username,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email
                };

                var result = await userManager.CreateAsync(userIdentity, model.Password);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(userIdentity, "Member");
                    return RedirectToAction("User", "User");
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


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var user = context.Users.Find(id);
            return View(user);
        }

        [HttpPost]
        public IActionResult Delete(User user)
        {
            context.Users.Remove(user);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }

}

