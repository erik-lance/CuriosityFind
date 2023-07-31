using System.ComponentModel.DataAnnotations;

namespace CuriosityFind.Models
{
    public class Quiz
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public List<Question> Questions { get; set; } = new List<Question>();
    }
}
