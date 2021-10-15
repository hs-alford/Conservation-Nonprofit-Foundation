using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Treehuggers_WebApp01.Models;
using Treehuggers_WebApp01.ViewModel;

/* Reports controller renders all of the report tables for each respective
 view */

namespace Treehuggers_WebApp01.Areas.DataTables.Controllers
{
    [Area("DataTables")]
    [Authorize(Roles = "Staff,Admin,Member")]
    public class ReportsController : Controller
    {
        private treehon1_SQLContext context { get; set; }

        public ReportsController(treehon1_SQLContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult MembershipList()
        {
            var myTableResults =
         this.context.Membership_Lists.FromSqlRaw(
             "SELECT * FROM [treehon1_project].Membership_List").ToList();

            return View(myTableResults);
        }
        

        public IActionResult FundBalance()
        {
            var myTableResults =
         this.context.Fund_Balances.FromSqlRaw(
             "SELECT * FROM [treehon1_project].Fund_Balance").ToList();

            return View(myTableResults);
        }


        public IActionResult CalEventsDetail()
        {
            var myTableResults =
         this.context.CalEvents_Details.FromSqlRaw(
             "SELECT * FROM [treehon1_project].CalEvents_Detail").ToList();

            return View(myTableResults);
        }


        public IActionResult ContactList()
        {
            var myTableResults =
         this.context.Contact_Lists.FromSqlRaw(
             "SELECT * FROM [treehon1_project].Contact_List").ToList();

            return View(myTableResults);
        }


        public IActionResult ContactTransaction()
        {
            var myTableResults =
         this.context.Contact_Transactions.FromSqlRaw(
             "SELECT * FROM [treehon1_project].Contact_Transactions").ToList();

            return View(myTableResults);
        }


        public IActionResult FundList()
        {
            var myTableResults =
         this.context.Fund_Lists.FromSqlRaw(
             "SELECT * FROM [treehon1_project].Fund_List").ToList();

            return View(myTableResults);
        }

        public IActionResult FundTransDetail()
        {
            var myTableResults =
         this.context.Fund_Trans_Details.FromSqlRaw(
             "SELECT * FROM [treehon1_project].Fund_Trans_Detail").ToList();

            return View(myTableResults);
        }

        public IActionResult GroupList()
        {
            var myTableResults =
         this.context.Group_Lists.FromSqlRaw(
             "SELECT * FROM [treehon1_project].Group_List").ToList();

            return View(myTableResults);
        }
        public IActionResult GroupMembersList()
        {
            var myTableResults =
         this.context.Group_Members_Lists.FromSqlRaw(
             "SELECT * FROM [treehon1_project].Group_Members_List").ToList();

            return View(myTableResults);
        }

        public IActionResult MembershipTransactions()
        {
            var myTableResults =
         this.context.Membership_Transactions.FromSqlRaw(
             "SELECT * FROM [treehon1_project].Membership_Transactions").ToList();

            return View(myTableResults);
        }

        public IActionResult NewsDetail()
        {
            var myTableResults =
         this.context.News_Details.FromSqlRaw(
             "SELECT * FROM [treehon1_project].News_Detail").ToList();

            return View(myTableResults);
        }

    }
}
