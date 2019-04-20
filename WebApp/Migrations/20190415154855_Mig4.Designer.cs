﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NFCSystem.Data;

namespace NFCSystem.Migrations
{
    [DbContext(typeof(NFCScanContext))]
    [Migration("20190415154855_Mig4")]
    partial class Mig4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NFCSystem.Models.NFCScan", b =>
                {
                    b.Property<long>("ScanID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StudId")
                        .IsRequired();

                    b.Property<long>("TimeStamp");

                    b.Property<long>("UID");

                    b.HasKey("ScanID");

                    b.ToTable("NFCScans");
                });
#pragma warning restore 612, 618
        }
    }
}