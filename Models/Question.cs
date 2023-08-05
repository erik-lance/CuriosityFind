using System.ComponentModel.DataAnnotations;

namespace CuriosityFind.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        public string QuestionTitle { get; set; } = string.Empty;

        [Required]
        public List<string> Choices { get; set; } = new List<string>();

        [Required]
        public string Answer { get; set; } = string.Empty;

        public int QuizId { get; set; }
    }
}
