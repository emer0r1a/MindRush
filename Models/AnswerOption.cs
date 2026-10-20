using System.ComponentModel.DataAnnotations;

namespace MindRush.Models;

/// One answer card (A to D) belonging to a <see cref="Question"/>.
public class AnswerOption
{
    public int Id { get; set; }

    public int QuestionId { get; set; }
    public Question? Question { get; set; }

    [Required, MaxLength(80)]
    public string Text { get; set; } = "";

    public bool IsCorrect { get; set; }

    /// Default display order. The game shuffles options each round.
    public int SortOrder { get; set; }
}
