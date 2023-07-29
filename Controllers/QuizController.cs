using CuriosityFind.Data;

namespace CuriosityFind.Controllers
{
    public class QuizController
    {
        private readonly ApplicationDbContext _context;

        public QuizController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
