using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/* Model class for the Membership_LIst View */


namespace Treehuggers_WebApp01.Models /* Database Views for reports are given the "Models" namespace */
{                                     /* even though they are located inside "ReportViewModels, because"*/
                                      /* it is necessary for them to be used inside modelBuilder() */
    public class Membership_List
    {
       // public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street_Address1 { get; set; }
        public string Street_Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string username_email { get; set; }
        public string UserTypeID { get; set; }
        public string MemberClass { get; set; }
       // [DataType(DataType.Currency)]
        public decimal Monthly_Dues { get; set; }
        public string Date_Joined { get; set; }

    }
}
