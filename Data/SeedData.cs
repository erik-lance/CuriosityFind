using CuriosityFind.Models;
using static CuriosityFind.Data.QuizSeed;

namespace CuriosityFind.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext dbContext)
        {
            if (!dbContext.Quizzes.Any())
            {
                // Clear existing data on DB
                dbContext.Quizzes.RemoveRange(dbContext.Quizzes);
                dbContext.Questions.RemoveRange(dbContext.Questions);
                dbContext.SaveChanges();

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
