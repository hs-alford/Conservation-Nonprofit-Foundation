using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* Model class for the Group_Members_List View */


namespace Treehuggers_WebApp01.Models /* Database Views for reports are given the "Models" namespace */
{                                     /* even though they are located inside "ReportViewModels, because"*/
                                      /* it is necessary for them to be used inside modelBuilder() */
    public class Group_Members_List
    {
        public string Name { get; set; }
        public string Group_Name { get; set; }
        public string Member_Type { get; set; }
        public string Date_Joined { get; set; }
        public string Date_Terminated { get; set; }
        public string Comments { get; set; }
    }
}
