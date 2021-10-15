using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Treehuggers_WebApp01.Models;
using Treehuggers_WebApp01.ViewModel;

/* Controller for the Members Home folder. All three Role types are authorized */

namespace Treehuggers_WebApp01.Areas.Member.Controllers
{
    [Authorize(Roles = "Member,Staff,Admin")]
    [Area("Member")]
    public class HomeController : Controller
    {
        private UserManager<ApplicationUser> userManager;


        private treehon1_SQLContext context { get; set; }

        public HomeController(treehon1_SQLContext ctx, UserManager<ApplicationUser> userMngr)
        {
            context = ctx;
            userManager = userMngr;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Account(string email)
        {
            List<User> users = context.Users.ToList();

        
            User user = users.Find(u => u.username_email == email);
            
            return View(user);
        }

        public IActionResult MembershipList(string email)
        {
            List<Membership_List> memList = context.Membership_Lists.ToList();

           

            Membership_List user = memList.Find(u => u.username_email == email);

            return View(user);
        }

        public IActionResult MembershipTrans(string email)
        {

            List<User> users = context.Users.ToList();


            User user = users.Find(u => u.username_email == email);

            int id = user.UserID;

            IEnumerable<Membership_Transactions> trans = context.Membership_Transactions.AsEnumerable();
            IEnumerable<Membership_Transactions> memtrans = trans.Where(t => t.UserID == id);
            return View(memtrans);
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
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action =
                    (user.UserID == 0) ? "Add" : "Edit";
                return View(user);
            }
        }
    }
}
