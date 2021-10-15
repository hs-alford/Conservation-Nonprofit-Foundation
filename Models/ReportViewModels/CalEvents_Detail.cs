using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

/* Model class for the CalEvents_Detail View */

namespace Treehuggers_WebApp01.Models /* Database Views for reports are given the "Models" namespace */
{                                     /* even though they are located inside "ReportViewModels, because"*/  
                                      /* it is necessary for them to be used inside modelBuilder() */  
    public class CalEvents_Detail
    {
        public string Event_Date { get; set; }
        public string Event_Title { get; set; }
        public string Description { get; set; }
        public string Entered_By { get; set; }

    }
}
