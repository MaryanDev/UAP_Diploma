﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PFSC.Entities.PFSC_DBContext;
using System;

namespace PFSC.Entities.Migrations
{
    [DbContext(typeof(PfscDbContext))]
    partial class PfscDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PFSC.Entities.Entites.CityDistrict", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("CityDistricts");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvatarPath");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<DateTime?>("EndDate");

                    b.Property<int>("FactoryId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.Property<int>("PositionId");

                    b.Property<decimal>("Salary");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.HasIndex("PositionId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.EmployeeMark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmployeeId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeMakrs");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.Factory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("CountOfEmplyees");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<int>("DistrictId");

                    b.Property<bool>("IsApproved");

                    b.Property<double?>("Lattitude");

                    b.Property<double?>("Longittude");

                    b.Property<string>("SiteUrl");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("Factories");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.FactoryAdminNotification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("FactoryId");

                    b.Property<bool>("IsChecked");

                    b.Property<string>("NotificationText");

                    b.Property<int>("NotificationTypeId");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.HasIndex("NotificationTypeId");

                    b.ToTable("FactoryAdminNotifications");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.FactoryImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FactoryId");

                    b.Property<string>("Path");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.ToTable("FactoryImages");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.FactoryToProduction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FactoryId");

                    b.Property<int>("PrintingProductionId");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.HasIndex("PrintingProductionId");

                    b.ToTable("FactoryToProduction");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.FactoryToTechnology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<int>("FactoryId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FactoryId");

                    b.ToTable("FactoryToTechnology");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.FactoryWorkingHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("DayOfWeek");

                    b.Property<int>("FactoryId");

                    b.Property<string>("FromTime");

                    b.Property<string>("ToTime");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.ToTable("FactoryWorkingHours");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.Machine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("ManufacturerId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.MachineManufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("MachineManufacturers");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.MachineToFactory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FactoryId");

                    b.Property<int>("MachineId");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.HasIndex("MachineId");

                    b.ToTable("MachinesToFactories");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.NotificationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("NotificationTypes");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CompletedDate");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("CustomerName");

                    b.Property<string>("CustormerPhone");

                    b.Property<string>("Description");

                    b.Property<int?>("EmployeeId");

                    b.Property<int>("FactoryId");

                    b.Property<bool>("IsCompleted");

                    b.Property<int>("OrderStateId");

                    b.Property<int>("OrderValueId");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("FactoryId");

                    b.HasIndex("OrderStateId");

                    b.HasIndex("OrderValueId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.OrderState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("OrderStates");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.OrderValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("OrderValues");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.PrintingProduction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("PrintingProductions");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.PrintingTechnology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("PrintingTechnologies");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FactoryId");

                    b.Property<byte>("RankValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.RegistrationRequest", b =>
                {
                    b.Property<int>("FactoryId");

                    b.Property<string>("AuthorEmail");

                    b.Property<string>("AuthorName");

                    b.Property<string>("AuthorPhone");

                    b.Property<string>("AuthorPosition");

                    b.HasKey("FactoryId");

                    b.ToTable("RegistrationRequests");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("FactoryId");

                    b.Property<int>("ReviewResultId");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.HasIndex("ReviewResultId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.ReviewResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("ReviewResults");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvatarPath");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PFSC.Entities.Entites.Employee", b =>
                {
                    b.HasOne("PFSC.Entities.Entites.Factory", "Factory")
                        .WithMany("Employees")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PFSC.Entities.Entites.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PFSC.Entities.Entites.EmployeeMark", b =>
                {
                    b.HasOne("PFSC.Entities.Entites.Employee", "Employee")
                        .WithMany("EmployeeMarks")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PFSC.Entities.Entites.Factory", b =>
                {
                    b.HasOne("PFSC.Entities.Entites.CityDistrict", "District")
                        .WithMany("Factories")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PFSC.Entities.Entites.FactoryAdminNotification", b =>
                {
                    b.HasOne("PFSC.Entities.Entites.Factory", "Factory")
                        .WithMany("FactoryAdminNotifications")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PFSC.Entities.Entites.NotificationType", "NotificationType")
                        .WithMany("FactoryAdminNotifications")
                        .HasForeignKey("NotificationTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PFSC.Entities.Entites.FactoryImage", b =>
                {
                    b.HasOne("PFSC.Entities.Entites.Factory", "Factory")
                        .WithMany("FactoryImages")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PFSC.Entities.Entites.FactoryToProduction", b =>
                {
                    b.HasOne("PFSC.Entities.Entites.Factory", "Factory")
                        .WithMany("Production")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PFSC.Entities.Entites.PrintingProduction", "Production")
                        .WithMany("Factories")
                        .HasForeignKey("PrintingProductionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PFSC.Entities.Entites.FactoryToTechnology", b =>
                {
                    b.HasOne("PFSC.Entities.Entites.PrintingTechnology", "PrintingTechnology")
                        .WithMany("Factories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PFSC.Entities.Entites.Factory", "Factory")
                        .WithMany("Technologies")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PFSC.Entities.Entites.FactoryWorkingHours", b =>
                {
                    b.HasOne("PFSC.Entities.Entites.Factory", "Factory")
                        .WithMany("WorkingHours")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PFSC.Entities.Entites.Machine", b =>
                {
                    b.HasOne("PFSC.Entities.Entites.MachineManufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PFSC.Entities.Entites.MachineToFactory", b =>
                {
                    b.HasOne("PFSC.Entities.Entites.Factory", "Factory")
                        .WithMany("Machines")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PFSC.Entities.Entites.Machine", "Machine")
                        .WithMany("Factories")
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PFSC.Entities.Entites.Order", b =>
                {
                    b.HasOne("PFSC.Entities.Entites.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("PFSC.Entities.Entites.Factory", "Factory")
                        .WithMany("Orders")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PFSC.Entities.Entites.OrderState", "OrderState")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PFSC.Entities.Entites.OrderValue", "OrderValue")
                        .WithMany("Orders")
                        .HasForeignKey("OrderValueId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PFSC.Entities.Entites.Rating", b =>
                {
                    b.HasOne("PFSC.Entities.Entites.Factory", "Factory")
                        .WithMany("Ratings")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PFSC.Entities.Entites.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PFSC.Entities.Entites.RegistrationRequest", b =>
                {
                    b.HasOne("PFSC.Entities.Entites.Factory", "Factory")
                        .WithOne("RegistrationRequest")
                        .HasForeignKey("PFSC.Entities.Entites.RegistrationRequest", "FactoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PFSC.Entities.Entites.Review", b =>
                {
                    b.HasOne("PFSC.Entities.Entites.Factory", "Factory")
                        .WithMany("Reviews")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PFSC.Entities.Entites.ReviewResult", "ReviewResult")
                        .WithMany("Reviews")
                        .HasForeignKey("ReviewResultId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PFSC.Entities.Entites.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PFSC.Entities.Entites.User", b =>
                {
                    b.HasOne("PFSC.Entities.Entites.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
