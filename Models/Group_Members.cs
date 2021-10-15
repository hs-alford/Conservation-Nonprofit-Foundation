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

/* Model class created for the Group_Members Data Table. Configured in the 
 treehon1_SQLContext class. */

namespace Treehuggers_WebApp01.Models
{
    // if you need to reference the actual table use...
    // [Table("TableName")]
    [Table("Group_Members")]
    public class Group_Members
    {
#nullable disable
        [Key]
        public int GroupMemberID { get; set; }
#nullable disable
        public int GroupID { get; set; }
#nullable disable
        public int UserID { get; set; }
#nullable disable
        public string Member_Type { get; set; }
#nullable disable
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date_joined { get; set; }
#nullable enable
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date_terminated { get; set; }
#nullable enable
        public string? Comment { get; set; }
       

    }

}

