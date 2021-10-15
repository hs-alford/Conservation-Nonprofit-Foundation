using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Treehuggers_WebApp01.Models;
using Treehuggers_WebApp01.ViewModel;

/* Seperate controller for each data table which handles rendering the table view, 
 the edit/add view, and the logic of adding and editing each entity*/

namespace Treehuggers_WebApp01.Areas.DataTables.Controllers
{
    [Area("DataTables")]
    [Authorize(Roles = "Admin,Staff")]
    public class UserTransController : Controller
    {
        private treehon1_SQLContext context { get; set; }

        public UserTransController(treehon1_SQLContext ctx)
        {
            context = ctx;
        }

        public IActionResult UserTrans()
        {
            var table = new treehuggersViewModel
            {
                UserTrans = context.UserTrans.ToList()
            };
            return View(table);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new UserTrans());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var usertrans = context.UserTrans.Find(id);
            return View(usertrans);
        }

        [HttpPost]
        public IActionResult Edit(UserTrans usertrans)
        {
            if (ModelState.IsValid)
            {
                if (usertrans.UserTransID == 0)
                    context.UserTrans.Add(usertrans);
                else
                    context.UserTrans.Update(usertrans);
                context.SaveChanges();
                return RedirectToAction("UserTrans", "UserTrans");
            }
            else
            {
                ViewBag.Action =
                    (usertrans.UserTransID == 0) ? "Add" : "Edit";
                return View(usertrans);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var usertrans = context.Users.Find(id);
            return View(usertrans);
        }

        [HttpPost]
        public IActionResult Delete(UserTrans usertrans)
        {
            context.UserTrans.Remove(usertrans);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
