using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* Model class for the News_Detail View */

namespace Treehuggers_WebApp01.Models /* Database Views for reports are given the "Models" namespace */
{                                     /* even though they are located inside "ReportViewModels, because"*/
                                      /* it is necessary for them to be used inside modelBuilder() */
    public class News_Detail
    {
        public string Event_Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Entered_By { get; set; }
    }
}
