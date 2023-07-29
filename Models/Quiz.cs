using System.ComponentModel.DataAnnotations;

public class Quiz
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    public string Description { get; set; }
}