///////////////////////////////////////////////////////////////////////////////////////////////////
// Date             Developer           Description : This file is for the database context class
// 2021-03-12      Yahya Mirzaei 

using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    //tinfo200:[2021-03-13-yahyam2-dykstra1]
    //This is school context inherits and for the data base class context.
    public class SchoolContext : DbContext
    {

        //tinfo200:[2021-03-13-yahyam2-dykstra1] 
        //This line of the code connects the following together as data.
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        //tinfo200:[2021-03-13-yahyam2-dykstra1] 
        //This method specifying singular table names in the data base Context.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}

