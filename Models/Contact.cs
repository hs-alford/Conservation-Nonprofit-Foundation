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

/* Model class created for the Contact Data Table. Configured in the 
 treehon1_SQLContext class. */

namespace Treehuggers_WebApp01.Models
{
    // if you need to reference the actual table use...
    // [Table("TableName")]
    [Table("Contact")]
    public class Contact
    {
#nullable disable
        [Key]
        public int ContactID { get; set; }
#nullable disable
        public string username_email { get; set; }
#nullable disable
        public string Status { get; set; }
#nullable disable
        public string FirstName { get; set; }
#nullable disable
        public string LastName { get; set; }
#nullable disable
        public string Street_Address1 { get; set; }
#nullable disable
        public string Street_Address2 { get; set; }
#nullable disable
        public string City { get; set; }
#nullable disable
        public string State { get; set; }
#nullable disable
        public string Zip { get; set; }
#nullable disable
        public string Phone { get; set; }
#nullable disable
        public string ContactPrefrence { get; set; }
#nullable enable
        [DataType(DataType.Currency)]
        public decimal? Monthly_Dues { get; set; }
#nullable enable
        public DateTime? Date_Joined { get; set; }
#nullable enable
        public string? SolicitedBy { get; set; }
#nullable enable
        public string? Comments { get; set; }


    }

}

