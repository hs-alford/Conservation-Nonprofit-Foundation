using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* Model class for the Fund_List View */


namespace Treehuggers_WebApp01.Models /* Database Views for reports are given the "Models" namespace */
{                                     /* even though they are located inside "ReportViewModels, because"*/
                                      /* it is necessary for them to be used inside modelBuilder() */
    public class Fund_List
    {
        public int FundID { get; set; }
        public string Fund_Name { get; set; }
        public string Status { get; set; }
        public string Start_Date { get; set; }
        public string Stop_Date { get; set; }
    }
}
