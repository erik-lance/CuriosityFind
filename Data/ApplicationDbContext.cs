using Microsoft.EntityFrameworkCore;

namespace CuriosityFind.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Quiz> Quizzes { get; set; }
    }
}