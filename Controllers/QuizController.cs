using CuriosityFind.Data;
using Microsoft.AspNetCore.Mvc;

namespace CuriosityFind.Controllers
{
    public class QuizController
    {
        private readonly ApplicationDbContext _context;

        public QuizController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var quizzes = _context.Quizzes.ToList();
            return new JsonResult(quizzes);
        }
    }
}
