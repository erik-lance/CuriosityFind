using CuriosityFind.Models;
using Microsoft.EntityFrameworkCore;
using static CuriosityFind.Data.QuizSeed;

namespace CuriosityFind.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext dbContext)
        {
            // Clear existing data on DB
            dbContext.Database.ExecuteSqlRaw("DELETE FROM Quizzes");
            dbContext.Database.ExecuteSqlRaw("DELETE FROM Questions");
            dbContext.Database.ExecuteSqlRaw("DELETE FROM Options");

            if (!dbContext.Quizzes.Any())
            {
                // Seed Quizzes
                var quiz1 = Quiz1();
                var quiz2 = Quiz2();

                var quizzes = new List<Quiz>
                {
                    quiz1,
                    quiz2
                };

                dbContext.AddRange(quizzes);
                dbContext.SaveChanges();
            }
        }
    }
}
