using CuriosityFind.Data;
using Microsoft.AspNetCore.Mvc;
using CuriosityFind.Models;

namespace CuriosityFind.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuizController : ControllerBase
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

        [HttpGet]
        public IActionResult GetAllQuizzes()
        {
            var quizzes = _context.Quizzes.ToList();
            // Populate questions for each quiz

            var questions = _context.Questions.ToList();

            foreach (var quiz in quizzes)
            {
                var quizQuestions = questions.Where(q => q.QuizId == quiz.Id).ToList();
                quiz.Questions = quizQuestions;
            }

            return Ok(quizzes);
        }

        [HttpGet("{id}")]
        public IActionResult GetQuiz(int id)
        {
            var quiz = _context.Quizzes.Find(id);
            var questions = _context.Questions.Where(q => q.QuizId == quiz.Id).ToList();
            quiz.Questions = questions;

            return Ok(quiz);
        }

        [HttpPost]
        public IActionResult CreateQuiz([FromBody] Quiz quiz)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Quizzes.Add(quiz);
            _context.SaveChanges();
            return Ok(quiz);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateQuiz(int id, [FromBody] Quiz quiz)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var quizInDb = _context.Quizzes.Find(id);

            if (quizInDb == null)
            {
                return NotFound();
            }

            quizInDb.Title = quiz.Title;
            quizInDb.Description = quiz.Description;

            _context.SaveChanges();
            return Ok(quizInDb);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteQuiz(int id)
        {
            var quiz = _context.Quizzes.Find(id);
            if (quiz == null)
            {
                return NotFound();
            }
            else
            {
                // Remove questions first
                var questions = _context.Questions.Where(q => q.QuizId == quiz.Id).ToList();
                foreach (var question in questions)
                {
                    _context.Questions.Remove(question);
                }

                _context.Quizzes.Remove(quiz);
                _context.SaveChanges();
                return Ok(quiz);
            }
        }
    }
}