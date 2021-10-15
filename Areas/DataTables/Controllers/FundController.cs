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
    public class FundController : Controller
    {
        private treehon1_SQLContext context { get; set; }

        public FundController(treehon1_SQLContext ctx)
        {
            context = ctx;
        }


        public IActionResult Fund()
        {
            var table = new treehuggersViewModel
            {
                Funds = context.Funds.ToList()
            };
            return View(table);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Fund());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var fund = context.Funds.Find(id);
            return View(fund);
        }

        [HttpPost]
        public IActionResult Edit(Fund fund)
        {
            if (ModelState.IsValid)
            {
                if (fund.FundID == 0)
                    context.Funds.Add(fund);
                else
                    context.Funds.Update(fund);
                context.SaveChanges();
                return RedirectToAction("Fund", "Fund");
            }
            else
            {
                ViewBag.Action =
                    (fund.FundID == 0) ? "Add" : "Edit";
                return View(fund);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var fund = context.Funds.Find(id);
            return View(fund);
        }

        [HttpPost]
        public IActionResult Delete(Fund fund)
        {
            context.Funds.Remove(fund);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
