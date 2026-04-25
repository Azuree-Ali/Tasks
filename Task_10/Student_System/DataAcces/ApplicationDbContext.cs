using Microsoft.EntityFrameworkCore;
using Student_System.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student_System.DataAcces
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentSystem;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Homework>()
                .Property(h =>h.Content)
                .HasConversion<string>();
            modelBuilder.Entity<Homework>()
                .HasKey(h => h.HomeworkId);
            modelBuilder.Entity<Course>()
                .HasKey(c => c.CourseId);
            modelBuilder.Entity<Student>()
                .HasKey(s => s.StudentId);
            modelBuilder.Entity<Resource>()
                .HasKey(r => r.ResourceId);
            modelBuilder.Entity<StudentCourses>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    Name = "Ali Mohamed",
                    PhoneNumber = "0101234567",
                    RegisteredOn = new DateTime(2024, 1, 1)
                },
                new Student
                {
                    StudentId = 2,
                    Name = "Sara Ahmed",
                    RegisteredOn = new DateTime(2024, 1, 2)
                }
            );
            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    CourseId = 1,
                    Name = "C# Basics",
                    Price = 500
                },
                new Course
                {
                    CourseId = 2,
                    Name = "SQL",
                    Price = 400
                }
            );
            modelBuilder.Entity<Resource>().HasData(
                new Resource
                {
                    ResourceId = 1,
                    Name = "Intro PDF",
                    Url = "files/intro.pdf",
                    CourseId = 1
                },
                new Resource
                {
                    ResourceId = 2,
                    Name = "SQL Guide",
                    Url = "files/sql.pdf",
                    CourseId = 2
                }
            );
            modelBuilder.Entity<Homework>().HasData(
                new Homework
                {
                    HomeworkId = 1,
                    Content = "files/hw1.zip",
                    ContentType = ContentType.Zip,
                    SubmissionTime = new DateTime(2024, 1, 10),
                    StudentId = 1,
                    CourseId = 1
                },
                new Homework
                {
                    HomeworkId = 2,
                    Content = "files/hw2.pdf",
                    ContentType = ContentType.Pdf,
                    SubmissionTime = new DateTime(2024, 1, 11),
                    StudentId = 2,
                    CourseId = 2
                }
            );
        }
    }
}
