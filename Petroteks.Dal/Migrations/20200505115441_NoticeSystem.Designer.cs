﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Petroteks.Dal.Concreate.EntityFramework.Contexts;

namespace Petroteks.Dal.Migrations
{
    [DbContext(typeof(PetroteksDbContext))]
    [Migration("20200505115441_NoticeSystem")]
    partial class NoticeSystem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Petroteks.Entities.ComplexTypes.UI_Contact", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserid")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("Languageid")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUserid")
                        .HasColumnType("int");

                    b.Property<int>("WebSiteid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Languageid");

                    b.HasIndex("WebSiteid");

                    b.ToTable("UI_Contacts");
                });

            modelBuilder.Entity("Petroteks.Entities.ComplexTypes.UI_Footer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserid")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("Languageid")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUserid")
                        .HasColumnType("int");

                    b.Property<int>("WebSiteid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Languageid");

                    b.HasIndex("WebSiteid");

                    b.ToTable("UI_Footers");
                });

            modelBuilder.Entity("Petroteks.Entities.ComplexTypes.UI_Navbar", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutUs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserid")
                        .HasColumnType("int");

                    b.Property<string>("Home")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("Languageid")
                        .HasColumnType("int");

                    b.Property<string>("Languages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PetroBlog")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Products")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUserid")
                        .HasColumnType("int");

                    b.Property<int>("WebSiteid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Languageid");

                    b.HasIndex("WebSiteid");

                    b.ToTable("UI_Navbars");
                });

            modelBuilder.Entity("Petroteks.Entities.ComplexTypes.UI_Notice", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserid")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("Languageid")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUserid")
                        .HasColumnType("int");

                    b.Property<int>("WebSiteid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Languageid");

                    b.HasIndex("WebSiteid");

                    b.ToTable("UI_Notices");
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.AboutUsObject", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserid")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Keywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Languageid")
                        .HasColumnType("int");

                    b.Property<string>("MetaTags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUserid")
                        .HasColumnType("int");

                    b.Property<int>("WebSiteid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Languageid");

                    b.HasIndex("WebSiteid");

                    b.ToTable("AboutUsObjects");
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.Blog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserid")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Keywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Languageid")
                        .HasColumnType("int");

                    b.Property<string>("MetaTags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUserid")
                        .HasColumnType("int");

                    b.Property<int>("WebSiteid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Languageid");

                    b.HasIndex("WebSiteid");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserid")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("Languageid")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Parentid")
                        .HasColumnType("int");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUserid")
                        .HasColumnType("int");

                    b.Property<int>("WebSiteid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Languageid");

                    b.HasIndex("WebSiteid");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.DynamicPage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserid")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Keywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Languageid")
                        .HasColumnType("int");

                    b.Property<string>("MetaTags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUserid")
                        .HasColumnType("int");

                    b.Property<int>("WebSiteid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Languageid");

                    b.HasIndex("WebSiteid");

                    b.ToTable("DynamicPages");
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.Email", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserid")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUserid")
                        .HasColumnType("int");

                    b.Property<int>("WebSiteid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("WebSiteid");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.Language", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserid")
                        .HasColumnType("int");

                    b.Property<bool>("Default")
                        .HasColumnType("bit");

                    b.Property<string>("IconCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("KeyCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUserid")
                        .HasColumnType("int");

                    b.Property<int>("WebSiteid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("WebSiteid");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.MainPage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BottomContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserid")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Keywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Languageid")
                        .HasColumnType("int");

                    b.Property<string>("MetaTags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUserid")
                        .HasColumnType("int");

                    b.Property<int>("WebSiteid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Languageid");

                    b.HasIndex("WebSiteid");

                    b.ToTable("MainPages");
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.PrivacyPolicyObject", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserid")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Keywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Languageid")
                        .HasColumnType("int");

                    b.Property<string>("MetaTags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUserid")
                        .HasColumnType("int");

                    b.Property<int>("WebSiteid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Languageid");

                    b.HasIndex("WebSiteid");

                    b.ToTable("PrivacyPolicyObjects");
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Categoryid")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserid")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Keywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Languageid")
                        .HasColumnType("int");

                    b.Property<string>("MetaTags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("SubTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUserid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Categoryid");

                    b.HasIndex("Languageid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserid")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Role")
                        .HasColumnType("smallint");

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUserid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.Website", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BaseUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserid")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdateUserid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Websites");
                });

            modelBuilder.Entity("Petroteks.Entities.ComplexTypes.UI_Contact", b =>
                {
                    b.HasOne("Petroteks.Entities.Concreate.Language", "Language")
                        .WithMany()
                        .HasForeignKey("Languageid");

                    b.HasOne("Petroteks.Entities.Concreate.Website", "WebSite")
                        .WithMany()
                        .HasForeignKey("WebSiteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Petroteks.Entities.ComplexTypes.UI_Footer", b =>
                {
                    b.HasOne("Petroteks.Entities.Concreate.Language", "Language")
                        .WithMany()
                        .HasForeignKey("Languageid");

                    b.HasOne("Petroteks.Entities.Concreate.Website", "WebSite")
                        .WithMany()
                        .HasForeignKey("WebSiteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Petroteks.Entities.ComplexTypes.UI_Navbar", b =>
                {
                    b.HasOne("Petroteks.Entities.Concreate.Language", "Language")
                        .WithMany()
                        .HasForeignKey("Languageid");

                    b.HasOne("Petroteks.Entities.Concreate.Website", "WebSite")
                        .WithMany()
                        .HasForeignKey("WebSiteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Petroteks.Entities.ComplexTypes.UI_Notice", b =>
                {
                    b.HasOne("Petroteks.Entities.Concreate.Language", "Language")
                        .WithMany()
                        .HasForeignKey("Languageid");

                    b.HasOne("Petroteks.Entities.Concreate.Website", "WebSite")
                        .WithMany()
                        .HasForeignKey("WebSiteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.AboutUsObject", b =>
                {
                    b.HasOne("Petroteks.Entities.Concreate.Language", "Language")
                        .WithMany()
                        .HasForeignKey("Languageid");

                    b.HasOne("Petroteks.Entities.Concreate.Website", "WebSite")
                        .WithMany()
                        .HasForeignKey("WebSiteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.Blog", b =>
                {
                    b.HasOne("Petroteks.Entities.Concreate.Language", "Language")
                        .WithMany()
                        .HasForeignKey("Languageid");

                    b.HasOne("Petroteks.Entities.Concreate.Website", "WebSite")
                        .WithMany()
                        .HasForeignKey("WebSiteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.Category", b =>
                {
                    b.HasOne("Petroteks.Entities.Concreate.Language", "Language")
                        .WithMany()
                        .HasForeignKey("Languageid");

                    b.HasOne("Petroteks.Entities.Concreate.Website", "WebSite")
                        .WithMany()
                        .HasForeignKey("WebSiteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.DynamicPage", b =>
                {
                    b.HasOne("Petroteks.Entities.Concreate.Language", "Language")
                        .WithMany()
                        .HasForeignKey("Languageid");

                    b.HasOne("Petroteks.Entities.Concreate.Website", "WebSite")
                        .WithMany()
                        .HasForeignKey("WebSiteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.Email", b =>
                {
                    b.HasOne("Petroteks.Entities.Concreate.Website", "WebSite")
                        .WithMany()
                        .HasForeignKey("WebSiteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.Language", b =>
                {
                    b.HasOne("Petroteks.Entities.Concreate.Website", "WebSite")
                        .WithMany()
                        .HasForeignKey("WebSiteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.MainPage", b =>
                {
                    b.HasOne("Petroteks.Entities.Concreate.Language", "Language")
                        .WithMany()
                        .HasForeignKey("Languageid");

                    b.HasOne("Petroteks.Entities.Concreate.Website", "WebSite")
                        .WithMany()
                        .HasForeignKey("WebSiteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.PrivacyPolicyObject", b =>
                {
                    b.HasOne("Petroteks.Entities.Concreate.Language", "Language")
                        .WithMany()
                        .HasForeignKey("Languageid");

                    b.HasOne("Petroteks.Entities.Concreate.Website", "WebSite")
                        .WithMany()
                        .HasForeignKey("WebSiteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Petroteks.Entities.Concreate.Product", b =>
                {
                    b.HasOne("Petroteks.Entities.Concreate.Category", "Category")
                        .WithMany()
                        .HasForeignKey("Categoryid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Petroteks.Entities.Concreate.Language", "Language")
                        .WithMany()
                        .HasForeignKey("Languageid");
                });
#pragma warning restore 612, 618
        }
    }
}