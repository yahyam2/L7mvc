/////////////////////////////////////////////////////////////////////////////////////////////////////
// Date             Developer           
// 2021-03-12       Yahya Mirzaei 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-13-yahyam2-dykstra1] - This is the course object
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        //tinfo200:[2021-03-13-yahyam2-dykstra1]- this is the collection of enrollments. 
        public ICollection<Enrollment> Enrollments { get; set; }   

    }
}






