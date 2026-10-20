using System.ComponentModel.DataAnnotations;

namespace MindRush.Models;

/// A player identified by a display name. No account is needed.
public class Player
{
    public int Id { get; set; }

    [Required, MaxLength(GameSettings.MaxDisplayNameLength)]
    public string DisplayName { get; set; } = "";

    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

    public List<GameSession> Sessions { get; set; } = new();
}
