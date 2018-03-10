﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MvcCRM.Models;
using System;

namespace MvcCRM.Migrations
{
    [DbContext(typeof(MvcCRMContext))]
    [Migration("20180309034141_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("MvcCRM.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<int>("CelphoneNumber");

                    b.Property<string>("LegalDocument");

                    b.Property<string>("Name");

                    b.Property<string>("Sector");

                    b.Property<string>("WebSite");

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("MvcCRM.Models.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<int>("CelphoneNumber");

                    b.Property<int?>("ClientID");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.Property<string>("Position");

                    b.Property<string>("email");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("MvcCRM.Models.Meeting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClientID");

                    b.Property<DateTime>("Date");

                    b.Property<bool>("IsVirtual");

                    b.Property<string>("Title");

                    b.Property<int?>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("UserID");

                    b.ToTable("Meeting");
                });

            modelBuilder.Entity("MvcCRM.Models.SupportTicket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClientID");

                    b.Property<string>("Detail");

                    b.Property<string>("ReportedBy");

                    b.Property<string>("State");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.ToTable("SupportTicket");
                });

            modelBuilder.Entity("MvcCRM.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.Property<string>("email");

                    b.Property<string>("password");

                    b.Property<string>("role");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MvcCRM.Models.Contact", b =>
                {
                    b.HasOne("MvcCRM.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID");
                });

            modelBuilder.Entity("MvcCRM.Models.Meeting", b =>
                {
                    b.HasOne("MvcCRM.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID");

                    b.HasOne("MvcCRM.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("MvcCRM.Models.SupportTicket", b =>
                {
                    b.HasOne("MvcCRM.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID");
                });
#pragma warning restore 612, 618
        }
    }
}
