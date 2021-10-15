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

/* Model class created for the ContactTrans Data Table. Configured in the 
 treehon1_SQLContext class. */

namespace Treehuggers_WebApp01.Models
{
    // if you need to reference the actual table use...
    // [Table("TableName")]
    [Table("Contact_Trans")]
    public class Contact_Trans
    {
#nullable disable
        [Key]
        public int Contact_TransID { get; set; }
#nullable enable
        public int? ContactID { get; set; }
#nullable enable
        public int? UserID { get; set; }
#nullable enable
        public DateTime? Con_Date { get; set; }
#nullable enable
        public string? Con_Method { get; set; }
#nullable enable
        public string? Con_Staff_Name { get; set; }
#nullable enable
        public string? Con_Comments { get; set; }
       

    }

}

