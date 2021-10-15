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
    [Authorize(Roles ="Admin,Staff")]
    public class CalEventsController : Controller
    {
        private treehon1_SQLContext context { get; set; }

        public CalEventsController(treehon1_SQLContext ctx)
        {
            context = ctx;
        }

        public IActionResult CalEvents()
        {
            var table = new treehuggersViewModel
            {
                CalEvents = context.CalEvents.ToList()
            };
            return View(table);
        }
        
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new CalEvents());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var calevent = context.CalEvents.Find(id);
            return View(calevent);
        }

        [HttpPost]
        public IActionResult Edit(CalEvents calevent)
        {
            if (ModelState.IsValid)
            {
                if (calevent.CalEventsID == 0)
                    context.CalEvents.Add(calevent);
                else
                    context.CalEvents.Update(calevent);
                context.SaveChanges();
                return RedirectToAction("CalEvents", "CalEvents");
            }
            else
            {
                ViewBag.Action =
                    (calevent.CalEventsID == 0) ? "Add" : "Edit";
                return View(calevent);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var calevent = context.CalEvents.Find(id);
            return View(calevent);
        }

        [HttpPost]
        public IActionResult Delete(CalEvents calevent)
        {
            context.CalEvents.Remove(calevent);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
