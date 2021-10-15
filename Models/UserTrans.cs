using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

/* Model class created for the UserTrans Data Table. Configured in the 
 treehon1_SQLContext class. */

namespace Treehuggers_WebApp01.Models
{
    [Table("UserTrans")]
    public class UserTrans
    {
#nullable disable
        [Key]
        public int UserTransID { get; set; }
#nullable disable
        public int UserID { get; set; }
#nullable disable
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
#nullable disable
        [DataType(DataType.Currency)]
        public decimal Amt { get; set; }
#nullable disable
        public string MethodOfPmt { get; set; }
#nullable enable
        public string? Payment_Info { get; set; }
#nullable enable
        public string? Comment { get; set; }

    }
}
