﻿// <auto-generated />
using System;
using ExerciseTracker.Model.DbConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExerciseTracker.WebApi.Migrations
{
    [DbContext(typeof(ExerciseTrackerDbContext))]
    [Migration("20181026131318_InitialDb")]
    partial class InitialDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExerciseTracker.Model.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ExerciseId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExerciseDescription");

                    b.Property<short>("ExerciseType");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("ExerciseTracker.Model.ExerciseType", b =>
                {
                    b.Property<short>("Id")
                        .HasColumnName("ExerciseTypeId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ExerciseType");

                    b.HasData(
                        new { Id = (short)0, Name = "Cardio" },
                        new { Id = (short)1, Name = "Compound" },
                        new { Id = (short)2, Name = "Isolation" },
                        new { Id = (short)3, Name = "Stretch" }
                    );
                });

            modelBuilder.Entity("ExerciseTracker.Model.Set", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SetId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExerciseId");

                    b.Property<int>("Reps");

                    b.Property<int>("Weight");

                    b.Property<int>("WorkoutId");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("Set");
                });

            modelBuilder.Entity("ExerciseTracker.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("FirstName");

                    b.Property<int>("HeightInInches");

                    b.Property<string>("LastName");

                    b.Property<double>("WeightInPounds");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ExerciseTracker.Model.UserCredential", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserCredentialId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Credential");

                    b.Property<int>("UserId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserCredential");
                });

            modelBuilder.Entity("ExerciseTracker.Model.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("WorkoutId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EndTime");

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("UserId");

                    b.Property<DateTime>("WorkoutDate");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Workout");
                });

            modelBuilder.Entity("ExerciseTracker.Model.Set", b =>
                {
                    b.HasOne("ExerciseTracker.Model.Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ExerciseTracker.Model.Workout")
                        .WithMany("Sets")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ExerciseTracker.Model.UserCredential", b =>
                {
                    b.HasOne("ExerciseTracker.Model.User", "User")
                        .WithOne("UserCredential")
                        .HasForeignKey("ExerciseTracker.Model.UserCredential", "UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ExerciseTracker.Model.Workout", b =>
                {
                    b.HasOne("ExerciseTracker.Model.User")
                        .WithMany("Workouts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
