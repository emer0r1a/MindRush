namespace MindRush.Models;

/// One row of the leaderboard: a player's best score. Ties share a rank (1, 2, 2, 4).
public record LeaderboardEntry(int Rank, int PlayerId, string DisplayName, int BestScore);

/// The current player's best score and rank, for the "Your best run" card.
public record PlayerStanding(int BestScore, int Rank);
