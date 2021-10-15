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
    public class ContactTransController : Controller
    {
        private treehon1_SQLContext context { get; set; }

        public ContactTransController(treehon1_SQLContext ctx)
        {
            context = ctx;
        }

        public IActionResult ContactTrans()
        {
            var table = new treehuggersViewModel
            {
                Contact_Trans = context.Contact_Trans.ToList()
            };
            return View(table);

        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Contact_Trans());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var contrans = context.Contact_Trans.Find(id);
            return View(contrans);
        }

        [HttpPost]
        public IActionResult Edit(Contact_Trans contrans)
        {
            if (ModelState.IsValid)
            {
                if (contrans.Contact_TransID == 0)
                    context.Contact_Trans.Add(contrans);
                else
                    context.Contact_Trans.Update(contrans);
                context.SaveChanges();
                return RedirectToAction("ContactTrans", "ContactTrans");
            }
            else
            {
                ViewBag.Action =
                    (contrans.Contact_TransID == 0) ? "Add" : "Edit";
                return View(contrans);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contrans = context.Contact_Trans.Find(id);
            return View(contrans);
        }

        [HttpPost]
        public IActionResult Delete(Contact_Trans contrans)
        {
            context.Contact_Trans.Remove(contrans);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
