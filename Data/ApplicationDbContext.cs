using Microsoft.EntityFrameworkCore;
using Pattern.Models;

namespace StudentManagement.Data
{
    public class ApplicationDbContext :DbContext
    {
        public  ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
         
        }
        public DbSet<YearLevel> YearLevel { get; set; }
        public DbSet<DegreeProgram> DegreeProgram { get; set; }
    }
}
