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
    public class MemberController : Controller
    {
        private treehon1_SQLContext context { get; set; }

        public MemberController(treehon1_SQLContext ctx)
        {
            context = ctx;
        }

        public IActionResult Member()
        {
            var table = new treehuggersViewModel
            {
                Group_Members = context.Group_Members.ToList()
            };
            return View(table);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Group_Members());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var member = context.Group_Members.Find(id);
            return View(member);
        }

        [HttpPost]
        public IActionResult Edit(Group_Members member)
        {
            if (ModelState.IsValid)
            {
                if (member.GroupMemberID == 0)
                    context.Group_Members.Add(member);
                else
                    context.Group_Members.Update(member);
                context.SaveChanges();
                return RedirectToAction("Member", "Member");
            }
            else
            {
                ViewBag.Action =
                    (member.GroupMemberID == 0) ? "Add" : "Edit";
                return View(member);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var member = context.Group_Members.Find(id);
            return View(member);
        }

        [HttpPost]
        public IActionResult Delete(Group_Members member)
        {
            context.Group_Members.Remove(member);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
