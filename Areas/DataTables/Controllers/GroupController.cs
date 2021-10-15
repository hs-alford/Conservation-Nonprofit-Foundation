using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
    public class GroupController : Controller
    {
        private treehon1_SQLContext context { get; set; }

        public GroupController(treehon1_SQLContext ctx)
        {
            context = ctx;
        }

        public IActionResult Group()
        {
            var table = new treehuggersViewModel
            {
                Groups = context.Groups.ToList()
            };
            return View(table);

        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Groups());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var group = context.Groups.Find(id);
            return View(group);
        }

        [HttpPost]
        public IActionResult Edit(Groups group)
        {
            if (ModelState.IsValid)
            {
                if (group.GroupID == 0)
                    context.Groups.Add(group);
                else
                    context.Groups.Update(group);
                context.SaveChanges();
                return RedirectToAction("Group", "Group");
            }
            else
            {
                ViewBag.Action =
                    (group.GroupID == 0) ? "Add" : "Edit";
                return View(group);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var group = context.Groups.Find(id);
            return View(group);
        }

        [HttpPost]
        public IActionResult Delete(Groups group)
        {
            context.Groups.Remove(group);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
