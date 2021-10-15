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

/* Model class created for the News Data Table. Configured in the 
 treehon1_SQLContext class. */

namespace Treehuggers_WebApp01.Models
{
    // if you need to reference the actual table use...
    // [Table("TableName")]
    [Table("News")]
    public class News
    {
#nullable disable
        [Key]
        public int NewsID { get; set; }
#nullable disable
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime NewsDate { get; set; }
#nullable disable
        public string NewsTitle { get; set; }
#nullable enable
        public string? NewsDescrip { get; set; }
#nullable disable
        public int UserID { get; set; }



    }

}

