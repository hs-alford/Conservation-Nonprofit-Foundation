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

/* Model class created for the Group Data Table. Configured in the 
 treehon1_SQLContext class. */

namespace Treehuggers_WebApp01.Models
{
    // if you need to reference the actual table use...
    // [Table("TableName")]
    [Table("Groups")]
    public class Groups
    {
#nullable disable
        [Key]
        public int GroupID { get; set; }
#nullable disable
        public string Group_Type { get; set; }
#nullable disable
        public string Group_Status { get; set; }
#nullable disable
        public string Group_Name { get; set; }
#nullable disable
        public string Group_Desc { get; set; }
#nullable disable
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Group_Start_Date { get; set; }
#nullable enable
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Group_Stop_Date { get; set; }

    }

}

