namespace MindRush.Models;

/// Everything the Results page needs for one finished game.
public record ResultsViewModel(
    long SessionId,
    string PlayerName,
    int Score,
    int CorrectCount,
    int AnsweredCount,
    int Accuracy,
    int PreviousBest,
    bool IsPersonalBest,
    Achievement Badge)
{
    /// Builds the view model from a finished round and the player's best score before it.

    public static ResultsViewModel From(GameSession s, int previousBest)
    {
        var accuracy = s.AnsweredCount == 0
            ? 0
            : (int)Math.Round(s.CorrectCount * 100.0 / s.AnsweredCount);

        return new(
            s.Id,
            string.IsNullOrWhiteSpace(s.PlayerName) ? "Player" : s.PlayerName,
            s.Score,
            s.CorrectCount,
            s.AnsweredCount,
            accuracy,
            previousBest,
            s.Score > previousBest && s.Score > 0,
            Achievement.ForAccuracy(accuracy));
    }
}
