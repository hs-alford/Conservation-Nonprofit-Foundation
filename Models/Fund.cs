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

/* Model class created for the Fund Data Table. Configured in the 
 treehon1_SQLContext class. */

namespace Treehuggers_WebApp01.Models
{
    // if you need to reference the actual table use...
    // [Table("TableName")]
    [Table("Fund")]
    public class Fund
    {
#nullable disable
        [Key]
        public int FundID { get; set; }
#nullable disable
        public string Fund_Status { get; set; }
#nullable disable
        public string Fund_Name { get; set; }
#nullable disable
        [DataType(DataType.Currency)]
        public decimal Fund_Balance { get; set; }
#nullable disable
        public DateTime Fund_Start_Date { get; set; }
#nullable enable
        public DateTime? Fund_Stop_Date { get; set; }
    }

}

