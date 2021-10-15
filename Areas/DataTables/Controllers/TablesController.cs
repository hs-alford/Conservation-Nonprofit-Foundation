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
    public class TablesController : Controller
    {

        private treehon1_SQLContext context { get; set; }

        public TablesController(treehon1_SQLContext ctx)
        {
            context = ctx;
        }

        public IActionResult Tables()
        {
           
            return View();
        }

        

        
        
       
       

        
        
       
        
       
        

    }   
}
