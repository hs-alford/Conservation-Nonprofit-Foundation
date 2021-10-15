using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Treehuggers_WebApp01.Models;

/* ApplicationUser Model - extends the IdentityUser Class in Visual Studio and uses
 IdentityAppContext in order to configure the ASP.NET Core Identity Tables used for 
 storing user login and role data.  */
namespace Treehuggers_WebApp01.Models
{
    public class ApplicationUser : IdentityUser
    {
        /* IdentityUser class comes with its own default class values. These are additional user data 
         values we also want the data table to have. */
        public string FirstName { get; set; }
       
        public string LastName { get; set; }

        [NotMapped]
        public IList<string> RoleNames { get; set; }

    }
}
