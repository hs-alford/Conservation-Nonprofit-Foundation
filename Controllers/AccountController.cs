using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Treehuggers_WebApp01.Models;
using Treehuggers_WebApp01.ViewModel;
using Microsoft.AspNetCore.Session;

/* Account Controller is resposible for getting and returning the Login and 
 Register Views, along with controlling the actions and logic that deals with 
 the user logging into and out the site, along with registering and adding the
 user to the database. */

namespace Treehuggers_WebApp01.Controllers
{
    public class AccountController : Controller
    {
        // UserManager and SignInManager are both Identity classes
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        private treehon1_SQLContext context { get; set; }

        // Constructor for the Account Controller
        public AccountController(UserManager<ApplicationUser> userMngr,
            SignInManager<ApplicationUser> signInMngr, treehon1_SQLContext ctx)
        {
            userManager = userMngr;
            signInManager = signInMngr;
            context = ctx;
        }

        

        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }
                                                // HTTPGet Actions return views intitally
        [HttpGet]
        public IActionResult Login(string returnURL = "")
        {
            var model = new LoginViewModel { ReturnUrl = returnURL };
            return View(model);
        }

        [HttpPost]                              // HTTPPost Actions are preformed when called
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            /* When a new user registers one entry is made into the ApplicationUsers Table (login/role data) 
             and another entry with the other less sensitive user data is stored in the Users table. */
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
                    await signInManager.SignInAsync(userIdentity, isPersistent: false);
                    return RedirectToAction("Index", "Home");
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
        public async Task<IActionResult> LogIn(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.Username, model.Password, isPersistent: model.RememberMe,
                    lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Invalid username/password.");
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
