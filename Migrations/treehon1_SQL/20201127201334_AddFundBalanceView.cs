using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Treehuggers_WebApp01.Migrations.treehon1_SQL
{
    public partial class AddFundBalanceView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalEvents",
                columns: table => new
                {
                    CalEventsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalEventsDate = table.Column<DateTime>(nullable: false),
                    CalEventsName = table.Column<string>(nullable: true),
                    CalEventsDescrip = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalEvents", x => x.CalEventsID);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username_email = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Street_Address1 = table.Column<string>(nullable: true),
                    Street_Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    ContactPrefrence = table.Column<string>(nullable: true),
                    Monthly_Dues = table.Column<decimal>(nullable: true),
                    Date_Joined = table.Column<DateTime>(nullable: true),
                    SolicitedBy = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "Contact_Trans",
                columns: table => new
                {
                    Contact_TransID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactID = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: true),
                    Con_Date = table.Column<DateTime>(nullable: true),
                    Con_Method = table.Column<string>(nullable: true),
                    Con_Staff_Name = table.Column<string>(nullable: true),
                    Con_Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact_Trans", x => x.Contact_TransID);
                });

            migrationBuilder.CreateTable(
                name: "Fund",
                columns: table => new
                {
                    FundID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fund_Status = table.Column<string>(nullable: true),
                    Fund_Name = table.Column<string>(nullable: true),
                    Fund_Balance = table.Column<decimal>(nullable: false),
                    Fund_Start_Date = table.Column<DateTime>(nullable: false),
                    Fund_Stop_Date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fund", x => x.FundID);
                });

            migrationBuilder.CreateTable(
                name: "Fund_Trans",
                columns: table => new
                {
                    FundTransID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FundID = table.Column<int>(nullable: false),
                    Trans_Type = table.Column<string>(nullable: true),
                    Trans_Method = table.Column<string>(nullable: true),
                    Trans_Date = table.Column<DateTime>(nullable: false),
                    Trans_Amt = table.Column<decimal>(nullable: false),
                    Trans_UserID = table.Column<int>(nullable: false),
                    Trans_from_acctNo = table.Column<int>(nullable: true),
                    Trans_to_acctNo = table.Column<int>(nullable: true),
                    Trans_Description = table.Column<string>(nullable: true),
                    Check_No = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fund_Trans", x => x.FundTransID);
                });

            migrationBuilder.CreateTable(
                name: "Group_Members",
                columns: table => new
                {
                    GroupMemberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    Member_Type = table.Column<string>(nullable: true),
                    Date_joined = table.Column<DateTime>(nullable: false),
                    Date_terminated = table.Column<DateTime>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group_Members", x => x.GroupMemberID);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Group_Type = table.Column<string>(nullable: true),
                    Group_Status = table.Column<string>(nullable: true),
                    Group_Name = table.Column<string>(nullable: true),
                    Group_Desc = table.Column<string>(nullable: true),
                    Group_Start_Date = table.Column<DateTime>(nullable: false),
                    Group_Stop_Date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupID);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    NewsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsDate = table.Column<DateTime>(nullable: false),
                    NewsTitle = table.Column<string>(nullable: true),
                    NewsDescrip = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NewsID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username_email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserType = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Street_Address1 = table.Column<string>(nullable: true),
                    Street_Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    ContactPrefrence = table.Column<string>(nullable: true),
                    Monthly_Dues = table.Column<decimal>(nullable: false),
                    Date_Joined = table.Column<DateTime>(nullable: false),
                    SolicitedBy = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "UserTrans",
                columns: table => new
                {
                    UserTransID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Amt = table.Column<decimal>(nullable: false),
                    MethodOfPmt = table.Column<string>(nullable: true),
                    Payment_Info = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTrans", x => x.UserTransID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalEvents");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Contact_Trans");

            migrationBuilder.DropTable(
                name: "Fund");

            migrationBuilder.DropTable(
                name: "Fund_Trans");

            migrationBuilder.DropTable(
                name: "Group_Members");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserTrans");
        }
    }
}
