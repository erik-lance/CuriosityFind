using CuriosityFind.Models;

namespace CuriosityFind.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext dbContext)
        {
            if (!dbContext.Quizzes.Any())
            {
                // Seed Quizzes
                var quiz1 = QuizSeed.Quiz1();
                var quiz2 = QuizSeed.Quiz2();

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
