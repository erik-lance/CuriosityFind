using System.ComponentModel.DataAnnotations;

namespace CuriosityFind.Models
{
    public class Quiz
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public List<Question> Questions { get; set; }
    }
}
