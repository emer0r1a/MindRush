using System.ComponentModel.DataAnnotations;

namespace MindRush.Models;

/// A single trivia question with four answer options.
public class Question
{
    public int Id { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    [Required, MaxLength(200)]
    public string Text { get; set; } = "";

    /// Emoji used in the playful illustration on the question card.
    [MaxLength(8)]
    public string Emoji { get; set; } = "💡";

    public List<AnswerOption> Options { get; set; } = new();

    /// Index of the correct option in <see cref="Options"/> (as currently ordered).
    public int CorrectIndex => Options.FindIndex(o => o.IsCorrect);
}
