////////////////////////////////////////////////////////////////////////////
// Date             Developer           Description:
// 2021-03-12      Yahya Mirzaei 


namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
        
      
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }

    }
}
//tinfo200:[2021-03-13-yahyam2-dykstra1]
//Added class called course