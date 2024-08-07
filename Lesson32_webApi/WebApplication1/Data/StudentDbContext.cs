using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Entities;

namespace WebApplication1.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options):base(options)
        {

        }
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Student { get; set; }

       
    }
}
