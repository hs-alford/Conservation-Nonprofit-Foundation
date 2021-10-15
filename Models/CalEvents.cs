using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web;
using System.Globalization;
using System.Security.Principal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

/* Model class created for the CalEvents Data Table. Configured 
  in the treehon1_SQLContext class */

namespace Treehuggers_WebApp01.Models
{
    [Table("CalEvents")]
    public class CalEvents
    {
#nullable disable
        [Key]
        public int CalEventsID { get; set; }
#nullable disable
        public DateTime CalEventsDate { get; set; }
#nullable disable
        public string CalEventsName { get; set; }
#nullable enable
        public string? CalEventsDescrip { get; set; }
#nullable disable
        public int UserID { get; set; }
       

    }

}

