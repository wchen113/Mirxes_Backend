﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mirxes_Backend.Data;

#nullable disable

namespace Mirxes_Backend.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mirxes_Backend.Entities.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ShipTo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Mirxes_Backend.Entities.Items", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Mirxes_Backend.Entities.Outliers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("Date_Exhaustion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("GRN_Date")
                        .HasColumnType("date");

                    b.Property<int>("GRN_to_Post_Date")
                        .HasColumnType("int");

                    b.Property<int>("GRN_to_Required_Date")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Item_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("Last_Procurement")
                        .HasColumnType("date");

                    b.Property<bool>("Oversea")
                        .HasColumnType("bit");

                    b.Property<int>("PO_Number")
                        .HasColumnType("int");

                    b.Property<int>("Part_No")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Posting_Date")
                        .HasColumnType("date");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Required_Date")
                        .HasColumnType("date");

                    b.Property<int>("Required_to_Post_Date")
                        .HasColumnType("int");

                    b.Property<string>("Vendor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Outliers");
                });

            modelBuilder.Entity("Mirxes_Backend.Entities.RawMaterials", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("PartNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RawMaterials");
                });

            modelBuilder.Entity("Mirxes_Backend.Entities.SalesOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BackOrderQty")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("CommittedDelDate")
                        .HasColumnType("date");

                    b.Property<string>("CustCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerRefNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Delivered")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<int?>("EstimatedLeadTime")
                        .HasColumnType("int");

                    b.Property<decimal>("FulfillmentRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ItemNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemServiceDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("POReceivedDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("PostingDate")
                        .HasColumnType("date");

                    b.Property<decimal>("QtyOrdered")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateOnly?>("RowDeliveryDate")
                        .HasColumnType("date");

                    b.Property<string>("RowStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SONo")
                        .HasColumnType("int");

                    b.Property<string>("SalesType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShiptoCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TurnaroundDays")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SalesOrder");
                });

            modelBuilder.Entity("Mirxes_Backend.Entities.Suppliers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BPCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BPName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Mirxes_Backend.Entities.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
