﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using endoREG_MVC.Data;

namespace endoREG_MVC.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190710150309_simple-graphs")]
    partial class simplegraphs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("endoREG_MVC.Models.ActionItem", b =>
                {
                    b.Property<int>("ActionItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("ActionItemImage");

                    b.Property<bool>("Complete");

                    b.Property<int>("CompliancePlanId");

                    b.Property<DateTime>("DateAssigned")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("DaysToComplete");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Location");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<int>("Weight");

                    b.HasKey("ActionItemId");

                    b.HasIndex("CompliancePlanId");

                    b.HasIndex("UserId");

                    b.ToTable("ActionItem");
                });

            modelBuilder.Entity("endoREG_MVC.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("StreetAddress")
                        .IsRequired();

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "00000000-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e4e7f8f9-1e65-4799-907d-1a057072848b",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            FirstName = "Joe",
                            LastName = "Wellman",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPOTkl7XvUCdp+uhUtdJB82I7TpbUT5FnIYxk0FX3wQBOsS29gp0n4cCJQhJkrhWOQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                            StreetAddress = "123 NewForce Drive",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        });
                });

            modelBuilder.Entity("endoREG_MVC.Models.Completion", b =>
                {
                    b.Property<int>("CompletionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateCompleted");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int?>("ResponsiblePartyId");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("CompletionId");

                    b.HasIndex("ResponsiblePartyId");

                    b.HasIndex("UserId");

                    b.ToTable("Completion");
                });

            modelBuilder.Entity("endoREG_MVC.Models.CompletionActionItem", b =>
                {
                    b.Property<int>("CompletionActionItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActionItemId");

                    b.Property<int>("CompletionId");

                    b.HasKey("CompletionActionItemId");

                    b.HasIndex("ActionItemId");

                    b.HasIndex("CompletionId");

                    b.ToTable("CompletionActionItem");
                });

            modelBuilder.Entity("endoREG_MVC.Models.CompliancePlan", b =>
                {
                    b.Property<int>("CompliancePlanId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("CompliancePlanId");

                    b.ToTable("CompliancePlan");

                    b.HasData(
                        new
                        {
                            CompliancePlanId = 1,
                            Label = "29 CFR 1910 General Industry Compliance"
                        },
                        new
                        {
                            CompliancePlanId = 2,
                            Label = "29 CFR Part 1926 Construction Compliance"
                        },
                        new
                        {
                            CompliancePlanId = 3,
                            Label = "Responsible Care® Compliance Plan"
                        },
                        new
                        {
                            CompliancePlanId = 4,
                            Label = "Human Resource (HR) Services Compliance Plan"
                        },
                        new
                        {
                            CompliancePlanId = 5,
                            Label = "Health, Environmental, Safety, and Security (HES&S) Compliance Plan"
                        },
                        new
                        {
                            CompliancePlanId = 6,
                            Label = "Industrial Hygiene Compliance Plan"
                        },
                        new
                        {
                            CompliancePlanId = 7,
                            Label = "Risk Management Compliance Plan"
                        },
                        new
                        {
                            CompliancePlanId = 8,
                            Label = "Workers Compensation Compliance Plan"
                        },
                        new
                        {
                            CompliancePlanId = 9,
                            Label = "Quality Assurance / Control Compliance"
                        },
                        new
                        {
                            CompliancePlanId = 10,
                            Label = "Employee Training Compliance Plan"
                        });
                });

            modelBuilder.Entity("endoREG_MVC.Models.ResponsibleParty", b =>
                {
                    b.Property<int>("ResponsiblePartyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAssigned")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("Inactive");

                    b.Property<string>("NameOrGroup")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.Property<string>("NameOrGroupNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("ResponsiblePartyId");

                    b.HasIndex("UserId");

                    b.ToTable("ResponsibleParty");

                    b.HasData(
                        new
                        {
                            ResponsiblePartyId = 1,
                            DateAssigned = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Inactive = false,
                            NameOrGroup = "Safety Team",
                            NameOrGroupNumber = "001",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ResponsiblePartyId = 2,
                            DateAssigned = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Inactive = false,
                            NameOrGroup = "HR Team",
                            NameOrGroupNumber = "002",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("endoREG_MVC.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("endoREG_MVC.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("endoREG_MVC.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("endoREG_MVC.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("endoREG_MVC.Models.ActionItem", b =>
                {
                    b.HasOne("endoREG_MVC.Models.CompliancePlan", "CompliancePlan")
                        .WithMany("ActionItems")
                        .HasForeignKey("CompliancePlanId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("endoREG_MVC.Models.ApplicationUser", "User")
                        .WithMany("ActionItems")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("endoREG_MVC.Models.Completion", b =>
                {
                    b.HasOne("endoREG_MVC.Models.ResponsibleParty", "ResponsibleParty")
                        .WithMany("Completions")
                        .HasForeignKey("ResponsiblePartyId");

                    b.HasOne("endoREG_MVC.Models.ApplicationUser", "User")
                        .WithMany("Completions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("endoREG_MVC.Models.CompletionActionItem", b =>
                {
                    b.HasOne("endoREG_MVC.Models.ActionItem", "ActionItem")
                        .WithMany("CompletionActionItems")
                        .HasForeignKey("ActionItemId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("endoREG_MVC.Models.Completion", "Completion")
                        .WithMany("CompletionActionItems")
                        .HasForeignKey("CompletionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("endoREG_MVC.Models.ResponsibleParty", b =>
                {
                    b.HasOne("endoREG_MVC.Models.ApplicationUser", "User")
                        .WithMany("ResponsibleParties")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
