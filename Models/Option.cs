using System.ComponentModel.DataAnnotations;

namespace CuriosityFind.Models
{
    public class Option
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string OptionText { get; set; } = string.Empty;

        public int QuestionId { get; set; }
    }
}
