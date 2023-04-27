﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaxCalculator.Data;

namespace TaxCalculator.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190714140147_AddTaxCalculationTable")]
    partial class AddTaxCalculationTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);


            modelBuilder.Entity("TaxCalculator.Data.Models.UserTaxCalculation", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CalculationDate");

                b.Property<string>("EmailAddress");

                b.Property<string>("PostalCode");

                b.Property<decimal>("TaxCalculation")
                    .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                    .HasColumnType("decimal(18, 2)");

                b.Property<decimal>("AnnualIncome")
                    .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                    .HasColumnType("decimal(18, 2)");

                b.HasKey("Id");

                b.ToTable("UserTaxCalculation");
            });
#pragma warning restore 612, 618
        }
    }
}