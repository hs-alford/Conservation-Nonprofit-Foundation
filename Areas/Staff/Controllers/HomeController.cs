using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Treehuggers_WebApp01.Models;
using Treehuggers_WebApp01.ViewModel;

/* Home Controller for the staff area, authorized for staff and admin*/

namespace Treehuggers_WebApp01.Areas.Staff.Controllers
{
    [Authorize(Roles = "Staff,Admin")]
    [Area("Staff")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
