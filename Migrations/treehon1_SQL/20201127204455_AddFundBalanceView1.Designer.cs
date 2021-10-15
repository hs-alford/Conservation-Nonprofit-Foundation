﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Treehuggers_WebApp01.Models;

namespace Treehuggers_WebApp01.Migrations.treehon1_SQL
{
    [DbContext(typeof(treehon1_SQLContext))]
    [Migration("20201127204455_AddFundBalanceView1")]
    partial class AddFundBalanceView1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Treehuggers_WebApp01.Models.CalEvents", b =>
                {
                    b.Property<int>("CalEventsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CalEventsDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CalEventsDescrip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CalEventsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("CalEventsID");

                    b.ToTable("CalEvents");
                });

            modelBuilder.Entity("Treehuggers_WebApp01.Models.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPrefrence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Date_Joined")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Monthly_Dues")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolicitedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street_Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street_Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username_email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactID");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("Treehuggers_WebApp01.Models.Contact_Trans", b =>
                {
                    b.Property<int>("Contact_TransID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Con_Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Con_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Con_Method")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Con_Staff_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ContactID")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Contact_TransID");

                    b.ToTable("Contact_Trans");
                });

            modelBuilder.Entity("Treehuggers_WebApp01.Models.Fund", b =>
                {
                    b.Property<int>("FundID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Fund_Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Fund_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fund_Start_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fund_Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Fund_Stop_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("FundID");

                    b.ToTable("Fund");
                });

            modelBuilder.Entity("Treehuggers_WebApp01.Models.Fund_Trans", b =>
                {
                    b.Property<int>("FundTransID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Check_No")
                        .HasColumnType("int");

                    b.Property<int>("FundID")
                        .HasColumnType("int");

                    b.Property<decimal>("Trans_Amt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Trans_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Trans_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trans_Method")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trans_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Trans_UserID")
                        .HasColumnType("int");

                    b.Property<int?>("Trans_from_acctNo")
                        .HasColumnType("int");

                    b.Property<int?>("Trans_to_acctNo")
                        .HasColumnType("int");

                    b.HasKey("FundTransID");

                    b.ToTable("Fund_Trans");
                });

            modelBuilder.Entity("Treehuggers_WebApp01.Models.Group_Members", b =>
                {
                    b.Property<int>("GroupMemberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_joined")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_terminated")
                        .HasColumnType("datetime2");

                    b.Property<int>("GroupID")
                        .HasColumnType("int");

                    b.Property<string>("Member_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("GroupMemberID");

                    b.ToTable("Group_Members");
                });

            modelBuilder.Entity("Treehuggers_WebApp01.Models.Groups", b =>
                {
                    b.Property<int>("GroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Group_Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Group_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Group_Start_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Group_Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Group_Stop_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Group_Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Treehuggers_WebApp01.Models.News", b =>
                {
                    b.Property<int>("NewsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("NewsDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NewsDescrip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("NewsID");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Treehuggers_WebApp01.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPrefrence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_Joined")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Monthly_Dues")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolicitedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street_Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street_Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username_email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Treehuggers_WebApp01.Models.UserTrans", b =>
                {
                    b.Property<int>("UserTransID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("MethodOfPmt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Payment_Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserTransID");

                    b.ToTable("UserTrans");
                });
#pragma warning restore 612, 618
        }
    }
}
