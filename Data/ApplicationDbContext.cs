using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Abhishek_Dot_net_Assignment.Models;

namespace Abhishek_Dot_net_Assignment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Abhishek_Dot_net_Assignment.Models.Student> Student { get; set; } = default!;
        public DbSet<Abhishek_Dot_net_Assignment.Models.Course> Course { get; set; } = default!;
        public DbSet<Abhishek_Dot_net_Assignment.Models.Enrollment> Enrollment { get; set; } = default!;
        public DbSet<Abhishek_Dot_net_Assignment.Models.Enroll> Enroll { get; set; } = default!;
    }
}
