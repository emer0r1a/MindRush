namespace MindRush.Models;

///  A badge earned on the Results page, based on accuracy.
public record Achievement(string Title, string ColorClass, int MinAccuracy)
{
    private static readonly Achievement[] Tiers =
    {
        new("TRIVIA CHAMPION", "bg-[#FF8FB8]", 80),
        new("QUICK THINKER", "bg-[#6FC2FF]", 50),
        new("WARM-UP HERO", "bg-[#7ED957]", 0),
    };

    public static Achievement ForAccuracy(int accuracy) =>
        Tiers.First(t => accuracy >= t.MinAccuracy);
}
