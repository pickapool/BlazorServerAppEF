﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebReceipt.Server.AppDatabaseContext;

#nullable disable

namespace WebReceipt.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240620135119_Migration3")]
    partial class Migration3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebReceipt.Models.CedulaModel", b =>
                {
                    b.Property<int>("CedulaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CedulaId"));

                    b.Property<decimal>("AdditionCommunity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AdditionTax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BasicCommunity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BasicTax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Citizenship")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityTreasurer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CivilStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateIssued")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("GrossCommunity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GrossTax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("ICRNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("IncomeCommunity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("IncomeTax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Interest")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ORNumber")
                        .HasColumnType("int");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Paid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PlaceOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfIssue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SalaryCommunity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SalaryTax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<string>("SureName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tin")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("CedulaId");

                    b.ToTable("Cedulas", (string)null);
                });

            modelBuilder.Entity("WebReceipt.Models.NatureOfCollectionModel", b =>
                {
                    b.Property<int>("NatureOfCollectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NatureOfCollectionId"));

                    b.Property<string>("AccountCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("NatureName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceiptId")
                        .HasColumnType("int");

                    b.HasKey("NatureOfCollectionId");

                    b.HasIndex("ReceiptId");

                    b.ToTable("NatureOfCollections");
                });

            modelBuilder.Entity("WebReceipt.Models.PaymentTypeModel", b =>
                {
                    b.Property<long>("PaymentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PaymentTypeId"));

                    b.Property<string>("PaymentTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentTypeId");

                    b.ToTable("PaymentTypes", (string)null);
                });

            modelBuilder.Entity("WebReceipt.Models.ReceiptModel", b =>
                {
                    b.Property<int>("ReceiptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReceiptId"));

                    b.Property<string>("Agency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Cash")
                        .HasColumnType("bit");

                    b.Property<bool>("Check")
                        .HasColumnType("bit");

                    b.Property<string>("CollectionOfficer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateRecorded")
                        .HasColumnType("datetime2");

                    b.Property<string>("DraweeBank")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DraweeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DraweeNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fund")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MoneyOrder")
                        .HasColumnType("bit");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PaymentTypeId")
                        .HasColumnType("bigint");

                    b.Property<string>("Payor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("ReceiptId");

                    b.HasIndex("PaymentTypeId");

                    b.ToTable("Receipts", (string)null);
                });

            modelBuilder.Entity("WebReceipt.Models.UserAccountModel", b =>
                {
                    b.Property<int>("UserAccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserAccountId"));

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserAccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserAccountPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserAccountId");

                    b.ToTable("Accounts", (string)null);
                });

            modelBuilder.Entity("WebReceipt.Models.NatureOfCollectionModel", b =>
                {
                    b.HasOne("WebReceipt.Models.ReceiptModel", null)
                        .WithMany("ListOfNatures")
                        .HasForeignKey("ReceiptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebReceipt.Models.ReceiptModel", b =>
                {
                    b.HasOne("WebReceipt.Models.PaymentTypeModel", "PaymentType")
                        .WithMany()
                        .HasForeignKey("PaymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentType");
                });

            modelBuilder.Entity("WebReceipt.Models.ReceiptModel", b =>
                {
                    b.Navigation("ListOfNatures");
                });
#pragma warning restore 612, 618
        }
    }
}