// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230122144442_Iniurfdy")]
    partial class Iniurfdy
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Country", b =>
                {
                    b.Property<int>("CountrieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CountrieId"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RegionId")
                        .HasColumnType("integer");

                    b.HasKey("CountrieId");

                    b.HasIndex("RegionId");

                    b.ToTable("Countrys");
                });

            modelBuilder.Entity("Domain.Entities.DepartMent", b =>
                {
                    b.Property<int>("DepartMentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DepartMentId"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LocationId")
                        .HasColumnType("integer");

                    b.HasKey("DepartMentId");

                    b.HasIndex("LocationId");

                    b.ToTable("DepartMents");
                });

            modelBuilder.Entity("Domain.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EmployeeId"));

                    b.Property<int>("Comission_PCT")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("JobId")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("integer");

                    b.Property<decimal>("Salarary")
                        .HasColumnType("numeric");

                    b.HasKey("EmployeeId");

                    b.HasIndex("JobId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Domain.Entities.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("JobId"));

                    b.Property<string>("JobTitel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("MaxSalary")
                        .HasColumnType("numeric");

                    b.Property<decimal>("MinSalary")
                        .HasColumnType("numeric");

                    b.HasKey("JobId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("Domain.Entities.JobGrade", b =>
                {
                    b.Property<string>("GradeLevel")
                        .HasColumnType("text");

                    b.Property<decimal>("HighestSal")
                        .HasColumnType("numeric");

                    b.Property<decimal>("LowestSal")
                        .HasColumnType("numeric");

                    b.HasKey("GradeLevel");

                    b.ToTable("JobGrades");
                });

            modelBuilder.Entity("Domain.Entities.JobHistory", b =>
                {
                    b.Property<DateTime>("Stsrt_Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DepartMentId")
                        .HasColumnType("integer");

                    b.Property<int>("DepartMent_Id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("End_Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("JobId")
                        .HasColumnType("integer");

                    b.Property<int>("Job_Id")
                        .HasColumnType("integer");

                    b.HasKey("Stsrt_Date");

                    b.HasIndex("DepartMentId");

                    b.HasIndex("JobId");

                    b.ToTable("JobHistorys");
                });

            modelBuilder.Entity("Domain.Entities.Location", b =>
                {
                    b.Property<int>("Location_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Location_ID"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CountryId")
                        .HasColumnType("integer");

                    b.Property<string>("Postal_Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Statte_Province")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Street_Addres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Location_ID");

                    b.HasIndex("CountryId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Domain.Entities.Region", b =>
                {
                    b.Property<int>("Region_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Region_Id"));

                    b.Property<string>("Region_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Region_Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("Domain.Entities.Country", b =>
                {
                    b.HasOne("Domain.Entities.Region", "Region")
                        .WithMany("Countrie")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("Domain.Entities.DepartMent", b =>
                {
                    b.HasOne("Domain.Entities.Location", "Location")
                        .WithMany("DepartMent")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Domain.Entities.Employee", b =>
                {
                    b.HasOne("Domain.Entities.Job", "Job")
                        .WithMany("Employee")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Domain.Entities.JobHistory", b =>
                {
                    b.HasOne("Domain.Entities.DepartMent", "DepartMent")
                        .WithMany("JobHistory")
                        .HasForeignKey("DepartMentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Job", "Job")
                        .WithMany("JobHistory")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DepartMent");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Domain.Entities.Location", b =>
                {
                    b.HasOne("Domain.Entities.Country", "Country")
                        .WithMany("Location")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Domain.Entities.Country", b =>
                {
                    b.Navigation("Location");
                });

            modelBuilder.Entity("Domain.Entities.DepartMent", b =>
                {
                    b.Navigation("JobHistory");
                });

            modelBuilder.Entity("Domain.Entities.Job", b =>
                {
                    b.Navigation("Employee");

                    b.Navigation("JobHistory");
                });

            modelBuilder.Entity("Domain.Entities.Location", b =>
                {
                    b.Navigation("DepartMent");
                });

            modelBuilder.Entity("Domain.Entities.Region", b =>
                {
                    b.Navigation("Countrie");
                });
#pragma warning restore 612, 618
        }
    }
}
