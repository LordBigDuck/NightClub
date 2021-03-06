﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NightClub.Infrastructure.Contexts;

namespace NightClub.Infrastructure.Migrations
{
    [DbContext(typeof(NightClubContext))]
    [Migration("20200530171430_UpdateModel")]
    partial class UpdateModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NightClub.Core.Domains.Blacklist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Blacklists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndDate = new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MemberId = 1,
                            StartDate = new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("NightClub.Core.Domains.IdentityCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CardNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("NationalRegisterNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ValidityDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CardNumber")
                        .IsUnique();

                    b.HasIndex("MemberId");

                    b.ToTable("IdentityCards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1994, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CardNumber = 1000000001,
                            ExpirationDate = new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "John",
                            Lastname = "Doe",
                            MemberId = 1,
                            NationalRegisterNumber = "548.65.84-654-56",
                            ValidityDate = new DateTime(2017, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("NightClub.Core.Domains.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "john.doe@gmail.com",
                            IsActive = true
                        });
                });

            modelBuilder.Entity("NightClub.Core.Domains.MemberCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("MemberCards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "2f704a64-3be8-48f3-91ac-128450500adf",
                            IsActive = false,
                            MemberId = 1
                        },
                        new
                        {
                            Id = 2,
                            Code = "19d8e8fa-58f1-42c9-9f3c-2661ce6943b0",
                            IsActive = true,
                            MemberId = 1
                        });
                });

            modelBuilder.Entity("NightClub.Core.Domains.Blacklist", b =>
                {
                    b.HasOne("NightClub.Core.Domains.Member", "Member")
                        .WithMany("Blacklists")
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("NightClub.Core.Domains.IdentityCard", b =>
                {
                    b.HasOne("NightClub.Core.Domains.Member", null)
                        .WithMany("IdentityCards")
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("NightClub.Core.Domains.MemberCard", b =>
                {
                    b.HasOne("NightClub.Core.Domains.Member", "Member")
                        .WithMany("MemberCards")
                        .HasForeignKey("MemberId");
                });
#pragma warning restore 612, 618
        }
    }
}
