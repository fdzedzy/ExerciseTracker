using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ExerciseTracker.Model;
using ExerciseTracker.Model.ReferenceData;

namespace ExerciseTracker.Model.DbConfig
{
    public class ExerciseTrackerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserCredential> UserCredentials { get; set; }
        public DbSet<ExerciseType> ExerciseTypes { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Workout> Workouts { get; set; }

        public ExerciseTrackerDbContext(DbContextOptions options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserCredentialEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ExerciseTypeEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ExerciseEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SetEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WorkoutEntityTypeConfiguration());

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        internal class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
        {
            public void Configure(EntityTypeBuilder<User> builder)
            {
                builder.ToTable("User");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id).HasColumnName("UserId");

                builder.HasOne(x => x.UserCredential).WithOne(b => b.User).HasForeignKey<UserCredential>(b => b.UserId);
                
                // EF seems creates this correctly as long as I don't try to define it
                //builder.HasMany<Workout>().WithOne().HasForeignKey(x => x.UserId);
            }
        }

        internal class UserCredentialEntityTypeConfiguration : IEntityTypeConfiguration<UserCredential>
        {
            public void Configure(EntityTypeBuilder<UserCredential> builder)
            {
                builder.ToTable("UserCredential");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id).HasColumnName("UserCredentialId");
            }
        }

        internal class ExerciseEntityTypeConfiguration : IEntityTypeConfiguration<Exercise>
        {
            public void Configure(EntityTypeBuilder<Exercise> builder)
            {
                builder.ToTable("Exercise");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id).HasColumnName("ExerciseId");

            }
        }

        internal class ExerciseTypeEntityTypeConfiguration : IEntityTypeConfiguration<ExerciseType>
        {
            public void Configure(EntityTypeBuilder<ExerciseType> builder)
            {
                builder.ToTable("ExerciseType");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id).HasColumnName("ExerciseTypeId");

                foreach (var e in Enum.GetValues(typeof(ExerciseTypeEnum)).Cast<ExerciseTypeEnum>())
                {
                    builder.HasData(new ExerciseType { Id = e, Name = e.ToString() });
                }
            }
        }

        internal class SetEntityTypeConfiguration : IEntityTypeConfiguration<Set>
        {
            public void Configure(EntityTypeBuilder<Set> builder)
            {
                builder.ToTable("Set");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id).HasColumnName("SetId");

                builder.HasOne<Exercise>().WithMany().HasForeignKey(x => x.ExerciseId);
            }
        }

        internal class WorkoutEntityTypeConfiguration : IEntityTypeConfiguration<Workout>
        {
            public void Configure(EntityTypeBuilder<Workout> builder)
            {
                builder.ToTable("Workout");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id).HasColumnName("WorkoutId");

            }
        }
    }
}
