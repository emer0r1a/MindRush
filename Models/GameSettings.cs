namespace MindRush.Models;

/// Game rules in one place, so the pages and services never disagree.
public static class GameSettings
{
    public const int RoundSeconds = 60;
    public const int PointsPerCorrect = 10;
    public const int FeedbackDelayMs = 1000;
    public const int LowTimeSeconds = 10;
    public const int QuestionsPerRound = 30;
    public const int LeaderboardSize = 10;
    public const int MaxDisplayNameLength = 20;
}
