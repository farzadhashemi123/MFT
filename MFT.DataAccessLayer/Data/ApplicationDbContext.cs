using MFT.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace MFT.DataAccessLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        private const string connectionString = "server=.;database=MFTDb;trusted_connection=true;encrypt=false";

        public ApplicationDbContext() : 
            base(new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(connectionString).Options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
