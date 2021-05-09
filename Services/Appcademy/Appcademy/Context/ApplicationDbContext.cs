using System;
using Appcademy.Entities;
using Microsoft.EntityFrameworkCore;
namespace Appcademy.Context
{
  public class ApplicationDbContext: DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

      modelBuilder.Entity<StudentCourse>().HasKey(x => new { x.CourseId, x.StudentId });
      base.OnModelCreating(modelBuilder);
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }
  }
}
