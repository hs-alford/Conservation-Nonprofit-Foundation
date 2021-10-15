using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Treehuggers_WebApp01.Models;
using Treehuggers_WebApp01.ViewModel;
using Microsoft.EntityFrameworkCore;

/* treehon1_SQLContext - is the context class for every database entity other than 
 * ApplicationUser (Identity entity). Includes the models for the database that
 * was migrated with this application and the Views that were used. Extends EF Cores
   DbContext class which coordinates EF Core functionality  */

namespace Treehuggers_WebApp01.Models
{
    public class treehon1_SQLContext : DbContext
    {
        public treehon1_SQLContext(DbContextOptions<treehon1_SQLContext> options)
            : base(options)
        { }

        /* EF Core does not support SQL Views outright, so to use the Views we created for the 
         * reports we used the modelbuilder to map each of the model classes created for our views, 
         * to each respective View in the database. */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Fund_Balance>(eb =>
                {
                    eb.HasNoKey();
                    eb.ToView("Fund_Balance");
                    eb.Property(v => v.Fund_Name).HasColumnName("Fund_Name");
                    eb.Property(v => v.Current_Balance).HasColumnName("Current_Balance");

                });
            
            modelBuilder
                .Entity<CalEvents_Detail>(eb =>
                {
                    eb.HasNoKey();
                    eb.ToView("CalEvents_Detail");
                    eb.Property(v => v.Event_Date).HasColumnName("Event_Date");
                    eb.Property(v => v.Event_Title).HasColumnName("Event_Title");
                    eb.Property(v => v.Description).HasColumnName("Description");
                    eb.Property(v => v.Entered_By).HasColumnName("Entered_By");
                });
            
            modelBuilder
               .Entity<Contact_List>(eb =>
               {
                   eb.HasNoKey();
                   eb.ToView("Contact_List");
                   eb.Property(v => v.FirstName).HasColumnName("FirstName");
                   eb.Property(v => v.LastName).HasColumnName("LastName");
                   eb.Property(v => v.Street_Address1).HasColumnName("Street_Address1");
                   eb.Property(v => v.Street_Address2).HasColumnName("Street_Address2");
                   eb.Property(v => v.City).HasColumnName("City");
                   eb.Property(v => v.State).HasColumnName("State");
                   eb.Property(v => v.Zip).HasColumnName("Zip");
                   eb.Property(v => v.Phone).HasColumnName("Phone");
                   eb.Property(v => v.username_email).HasColumnName("username_email");
                   eb.Property(v => v.ContactPrefrence).HasColumnName("ContactPrefrence");
                   eb.Property(v => v.Date_Joined).HasColumnName("Date_Joined");
                   eb.Property(v => v.Monthly_Dues).HasColumnName("Monthly_Dues");
                   eb.Property(v => v.Status).HasColumnName("Status");
                   eb.Property(v => v.SolicitedBy).HasColumnName("SolicitedBy");
                   eb.Property(v => v.Comments).HasColumnName("Comments");

               });
            modelBuilder
               .Entity<Contact_Transactions>(eb =>
               {
                   eb.HasNoKey();
                   eb.ToView("Contact_Transactions");
                   eb.Property(v => v.Name).HasColumnName("Name");
                   eb.Property(v => v.Con_Date).HasColumnName("Con_Date");
                   eb.Property(v => v.Con_Method).HasColumnName("Con_Method");
                   eb.Property(v => v.Con_Staff_Name).HasColumnName("Con_Staff_Name");
                   eb.Property(v => v.Con_Comments).HasColumnName("Con_Comments");
               });
            modelBuilder
               .Entity<Fund_List>(eb =>
               {
                   eb.HasNoKey();
                   eb.ToView("Fund_List");
                   eb.Property(v => v.FundID).HasColumnName("FundID")
                    .HasColumnType("int");
                   eb.Property(v => v.Fund_Name).HasColumnName("Fund_Name");
                   eb.Property(v => v.Status).HasColumnName("Status");
                   eb.Property(v => v.Start_Date).HasColumnName("Start_Date");
                   eb.Property(v => v.Stop_Date).HasColumnName("Stop_Date");
               });
            modelBuilder
               .Entity<Fund_Trans_Detail>(eb =>
               {
                   eb.HasNoKey();
                   eb.ToView("Fund_Trans_Detail");
                   eb.Property(v => v.FundID).HasColumnName("FundID")
                    .HasColumnType("int");
                   eb.Property(v => v.Trans_Amt).HasColumnName("Trans_Amt");
                   eb.Property(v => v.Trans_Date).HasColumnName("TransDate");
                   eb.Property(v => v.Fund_Name).HasColumnName("Fund_Name");
                   eb.Property(v => v.Entered_By).HasColumnName("Entered_By");
                   eb.Property(v => v.Trans_Type).HasColumnName("Trans_Type");
                   eb.Property(v => v.Pmt_Method).HasColumnName("Pmt_Method");
                   eb.Property(v => v.Trans_frm_No).HasColumnName("Trans_frm_No");
                   eb.Property(v => v.Trans_frm_Nm).HasColumnName("Trans_frm_Nm");
                   eb.Property(v => v.Trans_Description).HasColumnName("Trans_Description");
                   eb.Property(v => v.Check_No).HasColumnName("Check_No");
               });
            
            modelBuilder
               .Entity<Group_List>(eb =>
               {
                   eb.HasNoKey();
                   eb.ToView("Group_List");
                   eb.Property(v => v.GroupOrCommitteName).HasColumnName("Grp or Cmt Name");
                   eb.Property(v => v.Description).HasColumnName("Description");
                   eb.Property(v => v.Group_Type).HasColumnName("Group_Type");
                   eb.Property(v => v.Group_Status).HasColumnName("Group_Status");
                   eb.Property(v => v.Start_Date).HasColumnName("Start_Date");
                   eb.Property(v => v.End_Date).HasColumnName("End_Date");
               });
            
            modelBuilder
               .Entity<Group_Members_List>(eb =>
               {
                   eb.HasNoKey();
                   eb.ToView("Group_Members_List");
                   eb.Property(v => v.Name).HasColumnName("Name");
                   eb.Property(v => v.Group_Name).HasColumnName("Group_Name");
                   eb.Property(v => v.Member_Type).HasColumnName("MemberType");
                   eb.Property(v => v.Date_Joined).HasColumnName("Date_Joined");
                   eb.Property(v => v.Date_Terminated).HasColumnName("Date_Terminated");
                   eb.Property(v => v.Comments).HasColumnName("Comments");
               });
            modelBuilder
               .Entity<Membership_List>(eb =>
               {
                   eb.HasNoKey();
                   eb.ToView("Membership_List");
                   eb.Property(v => v.FirstName).HasColumnName("FirstName");
                   eb.Property(v => v.LastName).HasColumnName("LastName");
                   eb.Property(v => v.Street_Address1).HasColumnName("Street_Address1");
                   eb.Property(v => v.Street_Address2).HasColumnName("Street_Address2");
                   eb.Property(v => v.City).HasColumnName("City");
                   eb.Property(v => v.State).HasColumnName("State");
                   eb.Property(v => v.Zip).HasColumnName("Zip");
                   eb.Property(v => v.username_email).HasColumnName("username_email");
                   eb.Property(v => v.UserTypeID).HasColumnName("UserTypeID");
                   eb.Property(v => v.MemberClass).HasColumnName("MemberClass");
                   eb.Property(v => v.Date_Joined).HasColumnName("Date_Joined");
                   eb.Property(v => v.Monthly_Dues).HasColumnName("Monthly_Dues")
                    .HasColumnType("decimal(15,2)"); 
               });
            modelBuilder
               .Entity<Membership_Transactions>(eb =>
               {
                   eb.HasNoKey();
                   eb.ToView("Membership_Transactions");
                   eb.Property(v => v.UserID).HasColumnName("UserID")
                    .HasColumnType("int");
                   eb.Property(v => v.Trans_Amt).HasColumnName("Trans_Amt")
                    .HasColumnType("decimal(15,2)");
                   eb.Property(v => v.Trans_Date).HasColumnName("TranDate");
                   eb.Property(v => v.Firstname).HasColumnName("Firstname");
                   eb.Property(v => v.Lastname).HasColumnName("Lastname");
                   eb.Property(v => v.username_email).HasColumnName("username_email");
                   eb.Property(v => v.PmtID).HasColumnName("PmtID");
                   eb.Property(v => v.Pmt_Method).HasColumnName("Pmt_Method");
                   eb.Property(v => v.Comment).HasColumnName("Comment");
               });
            modelBuilder
               .Entity<News_Detail>(eb =>
               {
                   eb.HasNoKey();
                   eb.ToView("News_Detail");
                   eb.Property(v => v.Event_Date).HasColumnName("Event_Date");
                   eb.Property(v => v.Title).HasColumnName("Title");
                   eb.Property(v => v.Description).HasColumnName("Description");
                   eb.Property(v => v.Entered_By).HasColumnName("Entered_By");
               });
            
        }

        /* Each of the following DbSet<> lines creates a property for the entity set, 
         each entity set corresponds to a table or view in the database and each entity 
        corresponds to a row in the table. */

        // Tables
        public DbSet<User> Users { get; set; }
        public DbSet<UserTrans> UserTrans { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Group_Members> Group_Members { get; set; }
        public DbSet<Fund> Funds { get; set; }
        public DbSet<Fund_Trans> Fund_Trans { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Contact_Trans> Contact_Trans { get; set; }
        public DbSet<CalEvents> CalEvents { get; set; }
        public DbSet<News> News { get; set; }

        // Views
        public DbSet<Fund_Balance> Fund_Balances { get; set; }
        public DbSet<Contact_List> Contact_Lists { get; set; }
        public DbSet<CalEvents_Detail> CalEvents_Details { get; set; }
        public DbSet<Contact_Transactions> Contact_Transactions { get; set; }
        public DbSet<Fund_List> Fund_Lists { get; set; }
        public DbSet<Fund_Trans_Detail> Fund_Trans_Details { get; set; }
        public DbSet<Group_List> Group_Lists { get; set; }
        public DbSet<Group_Members_List> Group_Members_Lists { get; set; }
        public DbSet<Membership_List> Membership_Lists { get; set; }
        public DbSet<Membership_Transactions> Membership_Transactions { get; set; }
        public DbSet<News_Detail> News_Details { get; set; }
        
    }
}
