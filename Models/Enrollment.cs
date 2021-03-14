////////////////////////////////////////////////////////////////////////////
// Date             Developer          
// 2021-03-12      Yahya Mirzaei 


namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    //tinfo200:[2021-03-13-yahyam2-dykstra1] - This is the enrollment object
    public class Enrollment
    {
        //tinfo200:[2021-03-13-yahyam2-dykstra1]- this for the enrollment. 
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }

    }
}
