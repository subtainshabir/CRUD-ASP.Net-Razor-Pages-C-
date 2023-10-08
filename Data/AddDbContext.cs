using Microsoft.EntityFrameworkCore;
using Student_Management.Model;

namespace Student_Management.Data
{
    public class AddDbContext : DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options):base(options)
        {
            
        }

        public DbSet<Student> tbl_addstudent { get; set; }

    }
}
