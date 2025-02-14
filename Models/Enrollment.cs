//namespace Abhishek_Dot_net_Assignment.Models
//{
//    public class Enrollment
//    {
//    }
//}

namespace Abhishek_Dot_net_Assignment.Models
{
    public class Enrollment
    {
        // Primary Key
        public int EnrollmentId { get; set; }

        // Foreign Key to Student
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }  // Navigation property to Student

        // Foreign Key to Course
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }  // Navigation property to Course

        public DateTime EnrollmentDate { get; set; }

        public string Status { get; set; }
      
        public bool IsPaid { get; set; }

    }
}
