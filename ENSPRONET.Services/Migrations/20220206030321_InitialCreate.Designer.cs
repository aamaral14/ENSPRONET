﻿// <auto-generated />
using ENSPRONET.Services.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ENSPRONET.Services.Migrations
{
    [DbContext(typeof(ENSPRONETContext))]
    [Migration("20220206030321_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("ENSPRONET.Domains.Domains.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alpha2Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Alpha3Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("InternetDomain")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumericCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SubDivisionCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });
#pragma warning restore 612, 618
        }
    }
}
