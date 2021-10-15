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
    public class FundTransController : Controller
    {
        private treehon1_SQLContext context { get; set; }

        public FundTransController(treehon1_SQLContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Fund_Trans());
        }

        public IActionResult FundTrans()
        {
            var table = new treehuggersViewModel
            {
                Fund_Trans = context.Fund_Trans.ToList()
            };
            return View(table);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var fundtrans = context.Fund_Trans.Find(id);
            return View(fundtrans);
        }

        [HttpPost]
        public IActionResult Edit(Fund_Trans fundtrans)
        {
            if (ModelState.IsValid)
            {
                if (fundtrans.FundTransID == 0)
                    context.Fund_Trans.Add(fundtrans);
                else
                    context.Fund_Trans.Update(fundtrans);
                context.SaveChanges();
                return RedirectToAction("FundTrans", "FundTrans");
            }
            else
            {
                ViewBag.Action =
                    (fundtrans.FundTransID == 0) ? "Add" : "Edit";
                return View(fundtrans);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var fundtrans = context.Fund_Trans.Find(id);
            return View(fundtrans);
        }

        [HttpPost]
        public IActionResult Delete(Fund_Trans fundtrans)
        {
            context.Fund_Trans.Remove(fundtrans);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
