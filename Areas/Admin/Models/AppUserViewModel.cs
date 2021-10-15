using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Treehuggers_WebApp01.Models;

/*View Model used for the ApplicaitonUser View and editing it */

namespace Treehuggers_WebApp01.Areas.Admin.Models
{
    public class AppUserViewModel
    {
        public IEnumerable<ApplicationUser> AppUsers { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}
