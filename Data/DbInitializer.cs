////////////////////////////////////////////////////////////////////////////
// Date             Developer           Description: 
// 2021-03-12      Yahya Mirzaei 


//tinfo200:[2021-03-13-yahyam2-dykstra1]
// This file of code creates a database and the data goes into database


using ContosoUniversity.Models;
using System;
using System.Linq;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            //tinfo200:[2021-03-13-yahyam2-dykstra1]
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            //Assigned objects to Array
            var students = new Student[]
            {

             //tinfo200:[2021-03-13-yahyam2-dykstra1]
             // Data and object declaration

            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            //tinfo200:[2021-03-13-yahyam2-dykstra1]
            // Adding student ?????????????????????
            foreach (Student s in students)
            {
                // Adding student
                context.Students.Add(s);
            }
            // Saving the changes to the database
            context.SaveChanges();

            //tinfo200:[2021-03-13-yahyam2-dykstra1]
            // Assigned object to the array

            var courses = new Course[]
            {
            // Data and object declaration

            new Course{CourseID=1050,Title="Chemistry",Credits=3},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
            new Course{CourseID=1045,Title="Calculus",Credits=4},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4},
            new Course{CourseID=2021,Title="Composition",Credits=3},
            new Course{CourseID=2042,Title="Literature",Credits=4}
            };

            //??????
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();


            //tinfo200:[2021-03-13-yahyam2-dykstra1]
            // Assigned object to the array

            var enrollments = new Enrollment[]
            {
            //tinfo200:[2021-03-13-yahyam2-dykstra1]
            // Data and object declaration

            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}


//< !--//tinfo200:[2021-03-13-yahyam2-dykstra1] - Perliminary material being added to the home/Index method's view. -->
//@*
    //tinfo200:[2021-03-13-yahyam2-dykstra1] - Perliminary material being added to the home/Index method's view.
    //changed the home page for the Contoso University

//*@