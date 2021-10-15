using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

/* RoleConfiguration - extends the IdentityRole class which is another 
 Identity class used to set role types for the application. In this class 
 we configure the model builder to create three type of roles, the 
 Member, Staff, and Admin role types. */

namespace Treehuggers_WebApp01.Models.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Name = "Staff",
                NormalizedName = "STAFF"
            },
            new IdentityRole
            {
                Name = "Member",
                NormalizedName = "MEMBER"
            });
        }
    }
}
