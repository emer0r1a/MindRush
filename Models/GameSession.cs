
namespace MindRush.Models;

/// One finished 60-second round. Saved by the Game page, read by Results and Leaderboard.
public class GameSession
{
    public int Id { get; set; }

    public int PlayerId { get; set; }
    public Player? Player { get; set; }

    public DateTimeOffset StartedAt { get; set; } = DateTimeOffset.UtcNow;

    public int Score { get; set; }
    public int CorrectCount { get; set; }
    public int AnsweredCount { get; set; }
    public int DurationSeconds { get; set; }

    /// Accuracy as a whole percentage (0 to 100).
    public int Accuracy => AnsweredCount == 0 ? 0 : (int)Math.Round(CorrectCount * 100.0 / AnsweredCount);
}
