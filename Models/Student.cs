////////////////////////////////////////////////////////////////////////////
// Date             Developer           
// 2021-03-12      Yahya Mirzaei 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-13-yahyam2-dykstra1] - this is the student object
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //tinfo200:[2021-03-13-yahyam2-dykstra1] - this is for student enrollment. 
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
