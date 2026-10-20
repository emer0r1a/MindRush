namespace MindRush.Models;

/// Everything the Results page needs for one finished game.
public record ResultsViewModel(
    int SessionId,
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
    public static ResultsViewModel From(GameSession s, int previousBest) => new(
        s.Id,
        s.Player?.DisplayName ?? "Player",
        s.Score,
        s.CorrectCount,
        s.AnsweredCount,
        s.Accuracy,
        previousBest,
        s.Score > previousBest && s.Score > 0,
        Achievement.ForAccuracy(s.Accuracy));
}
