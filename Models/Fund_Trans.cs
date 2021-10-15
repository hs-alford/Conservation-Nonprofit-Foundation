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

/* Model class created for the Fund_Trans Data Table. Configured in the 
 treehon1_SQLContext class. */

namespace Treehuggers_WebApp01.Models
{
    // if you need to reference the actual table use...
    // [Table("TableName")]
    [Table("Fund_Trans")]
    public class Fund_Trans
    {
#nullable disable
        [Key]
        public int FundTransID { get; set; }
#nullable disable
        public int FundID { get; set; }
#nullable disable
        public string Trans_Type { get; set; }
#nullable disable
        public string Trans_Method { get; set; }
#nullable disable
        public DateTime Trans_Date { get; set; }
#nullable disable
        [DataType(DataType.Currency)]
        public decimal Trans_Amt { get; set; }
#nullable disable
        public int Trans_UserID { get; set; }
#nullable enable
        public int? Trans_from_acctNo { get; set; }
#nullable enable
        public int? Trans_to_acctNo { get; set; }
#nullable enable
        public string? Trans_Description { get; set; }
#nullable enable
        public int? Check_No { get; set; }



      
    }

}

