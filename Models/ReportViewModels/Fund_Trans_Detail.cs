using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* Model class for the Fund_Trans_Detail View */

namespace Treehuggers_WebApp01.Models /* Database Views for reports are given the "Models" namespace */
{                                     /* even though they are located inside "ReportViewModels, because"*/
                                      /* it is necessary for them to be used inside modelBuilder() */
    public class Fund_Trans_Detail
    {
        public int FundID { get; set; }
        public string Trans_Amt { get; set; }
        public string Trans_Date { get; set; }
        public string Fund_Name { get; set; }
        public string Entered_By { get; set; }
        public string Trans_Type { get; set; }
        public string Pmt_Method { get; set; }
        public string Trans_frm_No { get; set; }
        public string Trans_frm_Nm { get; set; }
        public string Trans_Description { get; set; }
        public string Check_No { get; set; }
    }
}
