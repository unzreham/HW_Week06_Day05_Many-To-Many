using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Models;

namespace CodeFirst.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {/*
            modelBuilder.Entity<RoomModel>()
                .Property(r => r.roomnUMBER)
                .IsRequired();

            modelBuilder.Entity<RoomModel>().Property(r => r.Empty).IsRequired();
             modelBuilder.Entity<StudentModel>().HasData(new StudentModel { studentId = 1, studentName = "Reham" });
             modelBuilder.Entity<StudentModel>().HasData(new StudentModel { studentId = 2, studentName = "Arwa" });
             modelBuilder.Entity<StudentModel>().HasData(new StudentModel { studentId = 3, studentName = "Amal" });
 */
            modelBuilder.Entity<Instructor_Student>()
                  .HasOne(s => s.Student)
                    .WithMany(i => i.Instructor_Students)
                    .HasForeignKey(s => s.StudentId);

            modelBuilder.Entity<Instructor_Student>()
                   .HasOne(i => i.Instructor)
                    .WithMany(i => i.Instructor_Students)
                    .HasForeignKey(i => i.InstructorId);


        }


   

        public DbSet<CourseModel> Course { get; set; }
        public DbSet<StudentModel> Student { get; set; }
        public DbSet<InstructorModel> Instructor { get; set; }
        public DbSet<RoomModel> Room { get; set; }

       public DbSet<Instructor_Student> instructor_Students { get; set; }


    }



}

/*public class PlacesDbContext : DbContext
{// ctor constructor
 // prop 
    public PlacesDbContext(DbContextOptions<PlacesDbContext> options) : base(options)
    {


    }*/