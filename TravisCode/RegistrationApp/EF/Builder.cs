using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata;
using RegistrationApp.Src;
using System;
namespace RegistrationApp.EF
{
  public class SchedulerAppDB : DbContext
  {
      public DbSet<Student> Students { get; set; }
      public DbSet<Instructor> Instructors { get; set; }
      public DbSet<Registrar> Registrars { get; set; }
      public DbSet<Course> Courses { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder builder)
      {
        builder.UseSqlServer("Server=tlarevdb1.database.windows.net;database=SchedulerAppDB;user id=tradmin;password=L0n3r1sm;");
      }
  }
}