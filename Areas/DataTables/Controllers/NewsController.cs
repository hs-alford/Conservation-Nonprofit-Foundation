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
    public class NewsController : Controller
    {
        private treehon1_SQLContext context { get; set; }

        public NewsController(treehon1_SQLContext ctx)
        {
            context = ctx;
        }


        public IActionResult News()
        {
            var table = new treehuggersViewModel
            {
                News = context.News.ToList()
            };
            return View(table);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new News());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var news = context.News.Find(id);
            return View(news);
        }

        [HttpPost]
        public IActionResult Edit(News news)
        {
            if (ModelState.IsValid)
            {
                if (news.NewsID == 0)
                    context.News.Add(news);
                else
                    context.News.Update(news);
                context.SaveChanges();
                return RedirectToAction("News", "News");
            }
            else
            {
                ViewBag.Action =
                    (news.NewsID == 0) ? "Add" : "Edit";
                return View(news);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var news = context.News.Find(id);
            return View(news);
        }

        [HttpPost]
        public IActionResult Delete(News news)
        {
            context.News.Remove(news);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
