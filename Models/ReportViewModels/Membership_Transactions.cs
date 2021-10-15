using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/* Model class for the Membership_Transactions View */


namespace Treehuggers_WebApp01.Models /* Database Views for reports are given the "Models" namespace */
{                                     /* even though they are located inside "ReportViewModels, because"*/
                                      /* it is necessary for them to be used inside modelBuilder() */
    public class Membership_Transactions
    {
        public int UserID { get; set; }
       // [DataType(DataType.Currency)]
        public decimal Trans_Amt { get; set; }
        public string Trans_Date { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string username_email { get; set; }
        public string PmtID { get; set; }
        public string Pmt_Method { get; set; }
        public string Comment { get; set; }
    }
}
