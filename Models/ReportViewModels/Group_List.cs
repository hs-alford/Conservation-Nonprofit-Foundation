using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* Model class for the Group_List View */

namespace Treehuggers_WebApp01.Models /* Database Views for reports are given the "Models" namespace */
{                                     /* even though they are located inside "ReportViewModels, because"*/
                                      /* it is necessary for them to be used inside modelBuilder() */
    public class Group_List
    {
        public string GroupOrCommitteName { get; set; }
        public string Description { get; set; }
        public string Group_Type { get; set; }
        public string Group_Status { get; set; }
        public string Start_Date { get; set; }
        public string End_Date { get; set; }
    }
}
