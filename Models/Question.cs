using System.ComponentModel.DataAnnotations;

namespace CuriosityFind.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        public string QuestionText { get; set; }

        [Required]
        public string Answer { get; set; }
    }
}
