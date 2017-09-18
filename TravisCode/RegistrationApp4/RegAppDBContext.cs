using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RegistrationApp4
{
    public partial class RegAppDBContext : DbContext
    {
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Instructors> Instructors { get; set; }
        public virtual DbSet<Students> Students { get; set; }

        // Unable to generate entity type for table 'dbo.StudentEnrollment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.InstructorEnrollment'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Courses>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CourseName).HasColumnType("nchar(100)");

                entity.Property(e => e.Dwstring)
                    .HasColumnName("DWstring")
                    .HasColumnType("nchar(5)");

                entity.Property(e => e.EndTime).HasColumnType("nchar(7)");

                entity.Property(e => e.InstructorId).HasColumnName("InstructorID");

                entity.Property(e => e.StartTime).HasColumnType("nchar(7)");

                entity.Property(e => e.SubjectCode).HasColumnType("nchar(8)");
            });

            modelBuilder.Entity<Instructors>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Fname).HasColumnType("nchar(30)");

                entity.Property(e => e.Lname).HasColumnType("nchar(30)");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Classification).HasColumnType("nchar(10)");

                entity.Property(e => e.Fname).HasColumnType("nchar(30)");

                entity.Property(e => e.Lname).HasColumnType("nchar(30)");

                entity.Property(e => e.Major).HasColumnType("nchar(100)");
            });
        }
    }
}
