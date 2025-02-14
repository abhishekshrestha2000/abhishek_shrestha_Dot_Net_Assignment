namespace Abhishek_Dot_net_Assignment.Models
{
    public class Enroll
    {
        public int EnrollId { get; set; } // Primary Key
        public int StudentId { get; set; } // Foreign Key for Student
        public int CourseId { get; set; } // Foreign Key for Course
        public DateTime EnrollmentDate { get; set; } // Date of Enrollment
        public string Status { get; set; } // Enrollment Status (e.g., Active, Completed, Dropped)
        public bool IsPaid { get; set; } // Indicates if the enrollment is paid

        // Navigation Properties (Optional)
      
    }
}
