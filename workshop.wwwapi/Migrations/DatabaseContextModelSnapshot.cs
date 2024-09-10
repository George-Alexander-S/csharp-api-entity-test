﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using workshop.wwwapi.Data;

#nullable disable

namespace workshop.wwwapi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("workshop.wwwapi.Models.Appointment", b =>
                {
                    b.Property<int>("PatientId")
                        .HasColumnType("integer");

                    b.Property<int>("DoctorId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Booking")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("PatientId", "DoctorId", "Booking");

                    b.HasIndex("DoctorId");

                    b.ToTable("appointments");

                    b.HasData(
                        new
                        {
                            PatientId = 1,
                            DoctorId = 1,
                            Booking = new DateTime(2024, 9, 14, 12, 30, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            PatientId = 2,
                            DoctorId = 2,
                            Booking = new DateTime(2024, 9, 14, 12, 30, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            PatientId = 3,
                            DoctorId = 3,
                            Booking = new DateTime(2024, 9, 14, 12, 30, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            PatientId = 3,
                            DoctorId = 1,
                            Booking = new DateTime(2024, 9, 14, 13, 30, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            PatientId = 3,
                            DoctorId = 2,
                            Booking = new DateTime(2024, 9, 14, 13, 30, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            PatientId = 1,
                            DoctorId = 3,
                            Booking = new DateTime(2024, 9, 14, 13, 30, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            PatientId = 2,
                            DoctorId = 1,
                            Booking = new DateTime(2024, 9, 14, 14, 30, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            PatientId = 1,
                            DoctorId = 2,
                            Booking = new DateTime(2024, 9, 14, 14, 30, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            PatientId = 2,
                            DoctorId = 3,
                            Booking = new DateTime(2024, 9, 14, 14, 30, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Hannibal",
                            LastName = "Lecter"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Henry",
                            LastName = "Jones Jr."
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Davy",
                            LastName = "Jones"
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Jane",
                            LastName = "Dough"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Hughie",
                            LastName = "Dodson"
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Appointment", b =>
                {
                    b.HasOne("workshop.wwwapi.Models.Doctor", null)
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("workshop.wwwapi.Models.Patient", null)
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Patient", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
