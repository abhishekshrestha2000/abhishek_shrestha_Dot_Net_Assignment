namespace Abhishek_Dot_net_Assignment.Models
{
    public class Student
    {
        public required int StudentId { get; set; }  // Primary Key
        public  required string StudentName { get; set; }

        public required string StudentEmail { get; set; }

        public required string StudentPhone { get; set; }
    }
}
