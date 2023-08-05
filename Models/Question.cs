using System.ComponentModel.DataAnnotations;

namespace CuriosityFind.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        public string QuestionTitle { get; set; } = string.Empty;

        [Required]
        public ICollection<Option> Options { get; set; } = new List<Option>();

        [Required]
        public string Answer { get; set; } = string.Empty;

        public int QuizId { get; set; }
    }
}
