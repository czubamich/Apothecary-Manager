// <auto-generated />
using System;
using ApothecaryManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApothecaryData.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20210504224111_UpdatedReverseProperties")]
    partial class UpdatedReverseProperties
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApothecaryManager.Data.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ApothecaryManager.Data.Model.Drug", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActiveSubstance")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("CategoryRefId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Dose")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("IsPrescribed")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("QuantityInPackage")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Unit")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryRefId");

                    b.ToTable("Drugs");
                });

            modelBuilder.Entity("ApothecaryManager.Data.Model.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Batch")
                        .HasColumnType("varchar(1000)");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(500)");

                    b.Property<int>("DrugRefId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("date");

                    b.Property<int>("QtyInStock")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierRefId")
                        .HasColumnType("int");

                    b.Property<double>("Tax")
                        .HasColumnType("float");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DrugRefId");

                    b.HasIndex("SupplierRefId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("ApothecaryManager.Data.Model.Prescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BarCode")
                        .IsRequired()
                        .HasColumnType("varchar(5000)");

                    b.Property<string>("Issuer")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PWZ")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Patient")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("ApothecaryManager.Data.Model.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SoldById")
                        .HasColumnType("int");

                    b.Property<int>("SoldByRefId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("isRefundable")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("SoldById");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("ApothecaryManager.Data.Model.SaleDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<int>("DrugRefId")
                        .HasColumnType("int");

                    b.Property<int?>("PrescriptionRefId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("Refund")
                        .HasColumnType("float");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DrugRefId");

                    b.HasIndex("PrescriptionRefId");

                    b.ToTable("SaleDetails");
                });

            modelBuilder.Entity("ApothecaryManager.Data.Model.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("ApothecaryManager.Data.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Level")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("License")
                        .HasColumnType("varchar(50)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(64)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(128)");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Username")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ApothecaryManager.Data.Model.Drug", b =>
                {
                    b.HasOne("ApothecaryManager.Data.Model.Category", "Category")
                        .WithMany("DrugsInCategory")
                        .HasForeignKey("CategoryRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ApothecaryManager.Data.Model.Inventory", b =>
                {
                    b.HasOne("ApothecaryManager.Data.Model.Drug", "Drug")
                        .WithMany()
                        .HasForeignKey("DrugRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApothecaryManager.Data.Model.Supplier", "Supplier")
                        .WithMany("Deliveries")
                        .HasForeignKey("SupplierRefId");

                    b.Navigation("Drug");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("ApothecaryManager.Data.Model.Sale", b =>
                {
                    b.HasOne("ApothecaryManager.Data.Model.User", "SoldBy")
                        .WithMany("Sales")
                        .HasForeignKey("SoldById");

                    b.Navigation("SoldBy");
                });

            modelBuilder.Entity("ApothecaryManager.Data.Model.SaleDetail", b =>
                {
                    b.HasOne("ApothecaryManager.Data.Model.Sale", "Drug")
                        .WithMany("SaleDetails")
                        .HasForeignKey("DrugRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApothecaryManager.Data.Model.Prescription", "Prescription")
                        .WithMany()
                        .HasForeignKey("PrescriptionRefId");

                    b.Navigation("Drug");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("ApothecaryManager.Data.Model.Category", b =>
                {
                    b.Navigation("DrugsInCategory");
                });

            modelBuilder.Entity("ApothecaryManager.Data.Model.Sale", b =>
                {
                    b.Navigation("SaleDetails");
                });

            modelBuilder.Entity("ApothecaryManager.Data.Model.Supplier", b =>
                {
                    b.Navigation("Deliveries");
                });

            modelBuilder.Entity("ApothecaryManager.Data.Model.User", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
