using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* Model class for the Contact_Transacitons View */


namespace Treehuggers_WebApp01.Models /* Database Views for reports are given the "Models" namespace */
{                                     /* even though they are located inside "ReportViewModels, because"*/
                                      /* it is necessary for them to be used inside modelBuilder() */
    public class Contact_Transactions
    {
        public string Name { get; set; }
        public string Con_Date { get; set; }
        public string Con_Method { get; set; }
        public string Con_Staff_Name { get; set; }
        public string Con_Comments { get; set; }
      
    }
}
